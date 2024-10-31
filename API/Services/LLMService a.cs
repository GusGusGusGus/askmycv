using API.Entities;
using API.Intefaces;
using LangChain.Databases.Sqlite;
using LangChain.DocumentLoaders;
using LangChain.Extensions;
using LangChain.Providers.Ollama;
using Microsoft.Extensions.Options;
using Ollama;


namespace API.Services
{
    public class LLMService : ILLMService
    {
        private bool isFirstRun;
        private AppUser _sender;
        private AppUser _receiver;
        private LLMOptions Options { get; }
        private OllamaProvider provider;
        private OllamaEmbeddingModel embeddingModel;
        private OllamaChatModel llm;
        private SqLiteVectorDatabase vectorDatabase;

        public LLMService(IOptions<LLMOptions> optionsAccessor)
        {
            Options = optionsAccessor.Value;
            // isFirstRun = true;
        }


        public async Task<string> RagAsync(string query)
        {

            var provider = new OllamaProvider();
            var embeddingModel = new OllamaEmbeddingModel(provider, id: "all-minilm");
            var llm = new OllamaChatModel(provider, id: "llama3");

            var vectorDatabase = new SqLiteVectorDatabase(dataSource: "vectors.db");

            var collection = await vectorDatabase.CreateCollectionAsync("testCollection", 1536);

            var vectorCollection = await vectorDatabase.CreateCollectionAsync <PdfPigPdfLoader>(
                embeddingModel, // Used to convert text to embeddings
                dimensions: 384, // Should be 384 for all-minilm
                dataSource: DataSource.FromUrl("https://canonburyprimaryschool.co.uk/wp-content/uploads/2016/01/Joanne-K.-Rowling-Harry-Potter-Book-1-Harry-Potter-and-the-Philosophers-Stone-EnglishOnlineClub.com_.pdf"),
                collectionName: "harrypotter", // Can be omitted, use if you want to have multiple collections
                textSplitter: null,
                behavior: AddDocumentsToDatabaseBehavior.JustReturnCollectionIfCollectionIsAlreadyExists);


            
            var similarDocuments = await vectorCollection.GetSimilarDocuments(embeddingModel, query, amount: 5);
            // Use similar documents and LLM to answer the question
            var answer = await llm.GenerateAsync(
                $"""
                Use the following pieces of context to answer the question at the end.
                If the answer is not in context then just say that you don't know, don't try to make up an answer.
                Keep the answer as short as possible.

                {similarDocuments.AsString()}

                Question: {query}
                Helpful Answer:
                """);

            return answer;
            throw new NotImplementedException();
        }


        

    }
}