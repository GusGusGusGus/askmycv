using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Intefaces;
using LangChain.Databases.Sqlite;
using LangChain.DocumentLoaders;
using LangChain.Extensions;
using LangChain.Providers;
using LangChain.Providers.Ollama;
using Document = LangChain.DocumentLoaders.Document;

namespace API.Services
{
    public class IngestionService : IIngestionService
    {
        private BlobStorageService _blobStorageService;
        private OllamaEmbeddingModel _embeddingModel;
        private OllamaChatModel _llm;
        private SqLiteVectorDatabase _vectorDatabase;
        private OllamaProvider _provider;

        public IngestionService(BlobStorageService blobStorageService, OllamaProvider provider)
        {
            _blobStorageService = blobStorageService;
            _embeddingModel = new OllamaEmbeddingModel(provider, id: "all-minilm");
            _provider = provider;
            _llm = new OllamaChatModel(provider, id: "llama3");
            _vectorDatabase = new SqLiteVectorDatabase(dataSource: "vectors.db");
        }

        public async Task ProcessUserDocumentAsync(AppUser appUser)
        {
            // Step 1: Download the file from Blob Storage
            var fileName = $"{appUser.Id}/CV";
            var fileStream = await _blobStorageService.DownloadFileAsync(fileName, appUser.Id.ToString() );
            if (fileStream == null)
            {
                throw new FileNotFoundException("File not found in Blob Storage.");
            }

            // Step 2: Check if the user has an existing IndexClusterId and delete if necessary
            if (!string.IsNullOrEmpty(appUser.IndexClusterId))
            {
                await _vectorDatabase.DeleteCollectionAsync(appUser.IndexClusterId);
            }

            // Step 3: Extract full text from PDF
            var pdfText = await ExtractTextFromPdfAsync(fileStream);

            // Step 4: Create chunks at multiple levels and summarize each
            var chunks = GenerateChunks(pdfText);
            var uniqueChunks = await SummarizeAndDeduplicateChunksAsync(chunks);

            // Step 5: Embed each unique chunk and store it in vector database
            var newCollectionName = Guid.NewGuid().ToString();
            await AddChunksToVectorDatabase(uniqueChunks, newCollectionName);

            // Update the user's IndexClusterId with the new collection name
            appUser.IndexClusterId = newCollectionName;
        }

        private async Task<string> ExtractTextFromPdfAsync(Stream pdfStream)
        {
            return PdfStreamReader.ReadPdfText(pdfStream);

        }

        /// <summary>
        /// Generates chunks based on RAPTOR hierarchy: going from high level concepts like full text and paragraphs, to lower level concepts like words or tokens
        /// </summary>
        /// <param name="fullText"></param>
        /// <returns></returns>
        private List<Chunk> GenerateChunks(string fullText)
        {
            var chunks = new List<Chunk>();

            // Level 1: Entire text as a single chunk
            chunks.Add(new Chunk { Level = 1, Text = fullText });

            // Level 2: Separate by sections (titles or headings) if possible
            var sectionedText = fullText.SplitBySections(); // Implement method based on PDF structure
            foreach (var section in sectionedText)
            {
                chunks.Add(new Chunk { Level = 2, Text = section });
            }

            // Level 3: Paragraph level
            foreach (var section in sectionedText)
            {
                var paragraphs = section.SplitParagraphs();
                foreach (var paragraph in paragraphs)
                {
                    chunks.Add(new Chunk { Level = 3, Text = paragraph });
                }
            }

            // Level 4: Sentence level
            foreach (var paragraph in sectionedText.SelectMany(s => s.SplitParagraphs()))
            {
                var sentences = paragraph.SplitSentences();
                foreach (var sentence in sentences)
                {
                    chunks.Add(new Chunk { Level = 4, Text = sentence });
                }
            }

            // Level 5: Word level
            foreach (var sentence in sectionedText.SelectMany(s => s.SplitParagraphs().SelectMany(p => p.SplitSentences())))
            {
                var words = sentence.SplitWords();
                foreach (var word in words)
                {
                    chunks.Add(new Chunk { Level = 5, Text = word });
                }
            }

            return chunks;
        }

        private async Task<List<Chunk>> SummarizeAndDeduplicateChunksAsync(List<Chunk> chunks)
        {
            var uniqueChunks = new Dictionary<string, Chunk>();

            foreach (var chunk in chunks)
            {
                string prompt = $"""
                Summarize the following text concisely:
                {chunk.Text}
                """;
                
                var message = new LangChain.Providers.Message(prompt, MessageRole.System);
                chunk.Summary = await _llm.GenerateAsync(ChatRequest.ToChatRequest(message));

                // Check if the chunk's summary already exists to avoid duplication
                if (!uniqueChunks.ContainsKey(chunk.Summary))
                {
                    uniqueChunks[chunk.Summary] = chunk;
                }
            }

            return uniqueChunks.Values.ToList();
        }

        private async Task AddChunksToVectorDatabase(List<Chunk> chunks, string collectionName)
        {
            var vectorCollection = await _vectorDatabase.GetOrCreateCollectionAsync(collectionName, dimensions: 384);

            foreach (var chunk in chunks)
            {
                var embedding = await _embeddingModel.CreateEmbeddingsAsync(chunk.Text);
                var documents = new List<Document>
                {
                    new Document(
                        content: chunk.Text,
                        metadata: new Dictionary<string, object> { { "Summary", chunk.Summary } }
                    )
                };
                
                await vectorCollection.AddDocumentsAsync(_embeddingModel, documents);
            }
        }
    }

    // Supporting classes and extensions

   
    public class Chunk
    {
        public int Level { get; set; }
        public string Text { get; set; }
        public string Summary { get; set; }
    }

    // Extension methods for splitting text
    public static class TextSplitterExtensions
    {
        public static List<string> SplitBySections(this string text)
        {
            // Implement custom logic to detect and split sections by titles, headings, etc.
            return new List<string> { text }; // Placeholder for section splitting logic
        }

        public static List<string> SplitParagraphs(this string text)
        {
            return text.Split(new[] { "\n\n", "\r\n\r\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public static List<string> SplitSentences(this string text)
        {
            return text.Split(new[] { ".", "!", "?" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        public static List<string> SplitWords(this string text)
        {
            return text.Split(new[] { " ", "\t", "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }
    }
}