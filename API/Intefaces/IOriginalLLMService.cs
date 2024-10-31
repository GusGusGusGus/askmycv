using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using OpenAI.Embeddings;
using Pinecone;

namespace API.Intefaces
{
    public interface IOriginalLLMService
    {
        // Task RouteRequestAsync(AppUser sender, string query, AppUser? receiver = null);
        // Task<string> CallChatGPTAPI_Completions(string prompt, string system, AppUser? profile = null);
        // Task<string> CallChatGPTAPILib(string query, List<string> choices, AppUser profile);
        // void PromptAdaptation(string query, out string prompt, out string system, out List<string> examples, List<string> choices, string context);
        // Task WriteProfileToVectorDB();
        // Task TraversePropertiesAndCreateVector(object obj, string indexClusterId, PineconeClient? pinecone);
        // Task<EmbeddingsResponse> EmbedValue(string value);
        // Task AddVectorToIndex(EmbeddingsResponse responseEmbedding, PineconeClient pinecone, string propertyName);
        // Task<ScoredVector[]> QueryIndex(EmbeddingsResponse responseEmbedding, PineconeClient pinecone, string query);

    }
}