// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Ollama;

// namespace API.Providers
// {
//     public sealed class OllamaProvider : LangChain.Providers.Provider, IDisposable
// {
//     private readonly HttpClient _httpClient;

//     public OllamaApiClient Api { get; }

//     public OllamaProvider(IHttpClientFactory httpClientFactory, string url = "http://localhost:11434/api")
//         : base(id: "ollama")
//     {
//         _httpClient = httpClientFactory.CreateClient();
//         _httpClient.Timeout = TimeSpan.FromHours(1);
//         Api = new OllamaApiClient(httpClient: _httpClient, baseUri: new Uri(url));
//     }

//     public void Dispose()
//     {
//         Api.Dispose();
//     }
// }
// }