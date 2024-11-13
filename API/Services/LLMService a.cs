using API.Entities;
using API.Intefaces;
using LangChain.Databases.Sqlite;
using LangChain.DocumentLoaders;
using LangChain.Extensions;
using LangChain.Providers;
using LangChain.Providers.Ollama;
using Microsoft.Extensions.Options;

namespace API.Services
{
    public class LLMService : ILLMService
    {
        private bool isFirstRun;
        private AppUser _sender;
        private AppUser _receiver;
        private LLMOptions Options { get; }
        private OllamaProvider _provider;
        private OllamaEmbeddingModel _embeddingModel;
        private OllamaChatModel _llm;
        private SqLiteVectorDatabase _vectorDatabase;
        private IngestionService _ingestionService;


        public LLMService(IOptions<LLMOptions> optionsAccessor, OllamaProvider provider, IngestionService ingestionService)
        {
            Options = optionsAccessor.Value;
            _provider = provider;
            _embeddingModel = new OllamaEmbeddingModel(provider, id: "all-minilm");
            _llm = new OllamaChatModel(provider, id: "llama3");
            _vectorDatabase = new SqLiteVectorDatabase(dataSource: "vectors.db");
            _ingestionService = ingestionService;
        }


        public async Task<string> RagAsync(string query)
        {
            var provider = new OllamaProvider();
            var embeddingModel = new OllamaEmbeddingModel(provider, id: "all-minilm");
            var llm = new OllamaChatModel(provider, id: "llama3");

            var vectorDatabase = new SqLiteVectorDatabase(dataSource: "vectors.db");

            var vectorCollection = await vectorDatabase.AddDocumentsFromAsync<PdfPigPdfLoader>(
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
        }


        public async Task<string> CorrectiveRagAsync(string query)
        {
            var state = new RagState(query);

            while (true)  // Main execution loop for rephrasing if necessary
            {
                // Step 1: Query Rewrite - optimize the question's abstraction level
                var optimizedQuery = await RewriteQueryIfNeeded(query);
                state.Add("optimizedQuery", optimizedQuery);

                // Step 2: Router - decide between Vector DB or Agent
                if (await ShouldUseVectorDatabase(optimizedQuery))
                {
                    // Step 3: Query the Vector Database
                    var similarDocuments = await QueryVectorDatabase(optimizedQuery, state);

                    // Step 4: Grade Relevance of Results
                    var isRelevant = await GradeRelevance(optimizedQuery, similarDocuments);

                    if (isRelevant)
                    {
                        // Step 5: Generate Response
                        var response = await GenerateResponseFromContext(optimizedQuery, similarDocuments);

                        // Step 6: Grade Answer - Verify if the response answers the original query
                        var isAnswerSatisfactory = await GradeAnswer(response, query);
                        if (isAnswerSatisfactory)
                        {
                            return response;  // Return the satisfactory response
                        }
                        else
                        {
                            // Rephrase the question if answer is unsatisfactory and restart the loop
                            query = await RephraseQuery(query);
                            continue;  // Restart the process with the rephrased query
                        }
                    }
                    else
                    {
                        // Fallback: Use web search or another method to get information
                        return await SearchWebAndRespond(optimizedQuery);
                    }
                }
                else
                {
                    // Use agent (implementation to be done later)
                    return await UseAgent(optimizedQuery);
                }
            }
        }

        private async Task<bool> GradeAnswer(string response, string originalQuery)
        {
            var gradePrompt = $"""
            Determine if the following response directly and satisfactorily answers the original question.
            Original Question: {originalQuery}
            Response: {response}
            Answer "yes" if it fully addresses the question; otherwise answer "no":
            """;

            var gradingResponse = await _llm.GenerateAsync(gradePrompt);
            return gradingResponse.ToString().ToLower().Contains("yes");
        }

        private async Task<string> RephraseQuery(string query)
        {
            var rephrasePrompt = $"""
            The following query did not yield a satisfactory answer. Please rephrase the question to make it clearer or more specific.

            Original Question: {query}
            Rephrased Question:
            """;

            var rephrasedQuery = await _llm.GenerateAsync(rephrasePrompt);
            return rephrasedQuery.LastMessageContent.Trim();
        }

        private async Task<string> RewriteQueryIfNeeded(string query)
        {
            // Ask LLM to determine if the query needs to be rephrased
            var rewritePrompt = $"""
            You are an assistant optimizing queries for an AI system.
            Evaluate the following question and determine if it should be more abstract or more specific
            to make the answer more efficient and accurate.

            Original Question: {query}

            Please rewrite the question if needed, or respond with "No Change" if it is already optimal.
            """;

            var rewriteResponse = await _llm.GenerateAsync(rewritePrompt);

            return rewriteResponse.LastMessageContent.Trim().Equals("No Change", StringComparison.OrdinalIgnoreCase)
                ? query
                : rewriteResponse.LastMessageContent.Trim();
        }

        private async Task<bool> ShouldUseVectorDatabase(string query)
        {
            // Use LLM to evaluate if the query is suitable for the vector database
            var routerPrompt = $"""
            Determine if the following query should use the vector database or an agent.
            If vector database is more appropriate, respond with "use vector database".
            If an agent is more appropriate, respond with "use agent".
            
            Query: {query}
            """;

            var routerResponse = await _llm.GenerateAsync(routerPrompt);
            return routerResponse.LastMessageContent.Trim().ToLower().Contains("use vector database");
        }

        private async Task<IReadOnlyCollection<LangChain.DocumentLoaders.Document>?> QueryVectorDatabase(string query, RagState state)
        {
            string userIndexClusterId = state.Get<string>("userIndexClusterId");
            var documents = await _vectorDatabase
                .GetCollectionAsync(userIndexClusterId); // User's specific collection
            var similarDocuments = (IReadOnlyCollection<LangChain.DocumentLoaders.Document>?) await documents.SearchAsync(_embeddingModel, query);

            // Store retrieved documents in state
            state.Add("similarDocuments", similarDocuments);
            return similarDocuments;
        }

        private async Task<bool> GradeRelevance(string query, IReadOnlyCollection<LangChain.DocumentLoaders.Document>? similarDocuments)
        {
            var gradingPrompt = $"""
            Determine if the following context is relevant to the user's question.
            Query: {query}
            Context: {similarDocuments.AsString()}
            Answer "yes" if relevant, otherwise "no":
            """;

            var gradingResponse = await _llm.GenerateAsync(gradingPrompt);
            return gradingResponse.LastMessageContent.ToLower().Contains("yes");
        }

        private async Task<string> GenerateResponseFromContext(string query, IReadOnlyCollection<LangChain.DocumentLoaders.Document>? similarDocuments)
        {
            var responsePrompt = $"""
            Use the following context to answer the query accurately and concisely.
            Context: {similarDocuments.AsString()}
            Query: {query}
            Answer:
            """;

            return await _llm.GenerateAsync(responsePrompt);
        }

        private async Task<string> SearchWebAndRespond(string query)
        {
            // Placeholder for web search fallback
            return $"Web search for: {query} (Functionality to be implemented)";
        }

        private async Task<string> UseAgent(string query)
        {
            // Placeholder for agent functionality
            return $"Agent processing for: {query} (Functionality to be implemented)";
        }
    }

    // Helper class for state management
    public class RagState
    {
        private readonly Dictionary<string, object> _state;

        public RagState(string initialQuery)
        {
            _state = new Dictionary<string, object> { { "query", initialQuery } };
        }

        public void Add(string key, object value) => _state[key] = value;
        public T Get<T>(string key) => _state.ContainsKey(key) ? (T)_state[key] : default;
    }

}
