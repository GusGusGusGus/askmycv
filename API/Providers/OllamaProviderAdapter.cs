// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;

// namespace API.Providers
// {
//     public class OllamaProviderAdapter
//     {
//         private readonly LangChain.Providers.Ollama.OllamaProvider _originalProvider;

//         public OllamaProviderAdapter(API.Providers.OllamaProvider customProvider)
//         {
//             // Initialize the original provider using information from the custom provider.
//             _originalProvider = new LangChain.Providers.Ollama.OllamaProvider(customProvider.Api.ToString());
//         }

//         // Expose the original provider where needed
//         public LangChain.Providers.Ollama.OllamaProvider GetOriginalProvider()
//         {
//             return _originalProvider;
//         }
//     }
// }