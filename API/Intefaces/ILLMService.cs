using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using OpenAI.Embeddings;
using Pinecone;

namespace API.Intefaces
{
    public interface ILLMService
    {
        Task<string> RagAsync(string question);
    }
}