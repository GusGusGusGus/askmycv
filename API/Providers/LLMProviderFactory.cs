// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using API.Intefaces;
// using LangChain.Providers.Ollama;
// using LangChain.Providers.Anthropic;
// using LangChain.Providers.OpenAI;
// using API.Entities.Enums;

// namespace API.Providers
// {
//     // Factory for creating providers
//     public class LLMProviderFactory
//     {
//         private readonly IServiceProvider _serviceProvider;
//         private readonly Dictionary<LLMProviderType, Lazy<ILLMProvider>> _providers;

//         public LLMProviderFactory(IServiceProvider serviceProvider)
//         {
//             _serviceProvider = serviceProvider;
//             _providers = new Dictionary<LLMProviderType, Lazy<ILLMProvider>>();
//         }

//         public ILLMProvider GetProvider(LLMProviderType providerType)
//         {
//             if (!_providers.ContainsKey(providerType))
//             {
//                 _providers[providerType] = new Lazy<ILLMProvider>(() => CreateProvider(providerType));
//             }

//             return _providers[providerType].Value;
//         }

//         private ILLMProvider CreateProvider(LLMProviderType providerType) 
//         => providerType switch
//             {
//                 LLMProviderType.Ollama => _serviceProvider.GetRequiredService<OllamaProvider>(),
//                 LLMProviderType.Claude => _serviceProvider.GetRequiredService<AnthropicProvider>(),
//                 LLMProviderType.OpenAI => _serviceProvider.GetRequiredService<OpenAiProvider>(),
//                 _ => throw new ArgumentException($"Unknown provider type: {providerType}")
//             };
//     }
// }