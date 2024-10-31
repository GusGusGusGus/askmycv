// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;
// using API.Entities;
// using OpenAI;
// using OpenAI.Chat;
// using OpenAIEmbeddings = OpenAI.Embeddings;
// using OpenAI.Models;
// using Pinecone;
// using Pinecone.Grpc;
// using OpenAI.Embeddings;
// using System.Reflection;
// using API.Utils;
// using Microsoft.Extensions.Options;
// using System.Text.Json;
// using API.Intefaces;
// using API.Entities.Consts;
// using API.DTOs;

// namespace API.Services
// {
//     public class OriginalLLMService : IOriginalLLMService
//     {
//         private bool isFirstRun;
//         private Index<Pinecone.Rest.RestTransport> _index;
//         private AppUser _profile;
//         private LLMOptions Options { get; }

//         public OriginalLLMService(IOptions<LLMOptions> optionsAccessor)
//         {
//             Options = optionsAccessor.Value;
//             // isFirstRun = true;
//         }

//         public async Task RouteRequestAsync(AppUser sender, string query, AppUser? receiver = null)
//         {
            
//             // var routeResponse = await CallChatGPTAPI_Completions(query, Prompts.SYSTEM_PROMPT_Routing, sender);
            
//         }


//         public async Task<string> CallChatGPTAPI_Completions(string prompt = "", string system= "", AppUser? profile = null)
//         {
//             //right now token count is around 1,080 tokens, depending on the questions
//             var inputData = new
//             {
//                 model = "gpt-3.5-turbo-1106",
//                 response_format = new { type = "json_object" },
//                 messages = new[]
//                 {
//                  new { role = "system", content = system },
//                  new { role = "user", content = prompt }
//              }
//             };

//             var jsonData = System.Text.Json.JsonSerializer.Serialize(inputData);

//             using (var httpClient = new HttpClient())
//             {
//                 var apiKey = Options.OpenAIKey;
//                 var apiUrl = "https://api.openai.com/v1/chat/completions";

//                 httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");
//                 httpClient.DefaultRequestHeaders.Add("Content-Type", $"application/json");

//                 var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
//                 var response = await httpClient.PostAsync(apiUrl, content);

//                 return await response.Content.ReadAsStringAsync();
//             }
//         }


//         public async Task<string> CallChatGPTAPILib(string query, List<string> choices, AppUser profile)
//         {
//             _profile = profile;
//             if (choices == null || choices.Count == 0)
//             {
//                 choices = new List<string>();
//             }

//             using var api = new OpenAIClient(Options.OpenAIKey);
//             using var pinecone = new PineconeClient(Options.PineconeAPIKey);

//             //var request = new CreateAssistantRequest("gpt-3.5-turbo-1106");
//             ////In case of Azure deployment:
//             //var auth = new OpenAIAuthentication(openAIKey);
//             //var settings = new OpenAIClientSettings(resourceName: "your-resource-name", deploymentId: "deployment-id", apiVersion: "api-version");
//             //using var api = new OpenAIClient(auth, settings);

//             //get this value from DB
//             if (String.IsNullOrEmpty(_profile.IndexClusterId))
//             {
//                 await WriteProfileToVectorDB();
//             }
//             var embeddedQuery = await EmbedValue(query);
//             var context = QueryIndex(embeddedQuery, pinecone, query);
//             var bestContext = context?.Result?.FirstOrDefault()?.Metadata.Values.Select(x => x.Inner);

//             // PromptAdaptation(query, out string prompt, out string system, out List<string> examples, choices, bestContext.ToString());

//             var messages = new List<OpenAI.Chat.Message>();
//             //if it's the first run, providing some examples
//             if (isFirstRun)
//             {
//                 var initialMessages = new List<OpenAI.Chat.Message>
//                 {
//                     new OpenAI.Chat.Message(OpenAI.Chat.System, system),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[0]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[1]), 
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[2]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[3]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[4]), 
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[5]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[6]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[7]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[8]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[9]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.User, examples[10]),
//                     new OpenAI.Chat.Message(OpenAI.Chat.Role.Assistant, examples[11]),
//                 };
//                 messages.AddRange(initialMessages);
//                 isFirstRun = false;
//             }

//             messages.Add(new OpenAIMessage(Role.User, query));
//             var chatRequest = new ChatRequest(messages, Model.GPT3_5_Turbo);

//             var response = await api.ChatEndpoint.GetCompletionAsync(chatRequest);
//             var choice = response.FirstChoice;
//             Console.WriteLine($"GPT Queried: {query}");
//             Console.WriteLine($"GPT API Response: {response}");
//             Console.WriteLine($"[{choice.Index}] {choice.Message.Role}: {choice.Message} | Finish Reason: {choice.FinishReason}");
//             Console.WriteLine("");

//             return response;

//         }


//         // public void PromptAdaptation(string query, out string prompt, out string system, out List<string> examples, List<string> choices, string context)
//         // {

//         //     system = $"### YOU ARE A JOB CANDIDATE. RESPOND TO THE QUERY BASED ON THE CONTEXT ABOUT YOU. When ALLOWED-RESPONSES are specified, format your response to one of the ALLOWED-RESPONSES. When ALLOWED-RESPONSES are not specified, don't format the response. ### Context: {context}";
//         //     examples = new List<string>();
//         //     examples.Add("### QUERY: Do you have experience with Software Development? ###" +
//         //                 "### ALLOWED-RESPONSES: No, Yes ###");
//         //     examples.Add("Yes");
//         //     examples.Add("### QUERY: Do you have experience with Rust? ###" +
//         //                 "### ALLOWED RESPONSES: No, Yes ###");
//         //     examples.Add("No");
//         //     examples.Add("### QUERY: What is your level of proficiency in English? ###");
//         //     examples.Add("Native");
//         //     examples.Add("### QUERY: What client-side languages can you use? ###");
//         //     examples.Add("React and Angular");
//         //     examples.Add("### QUERY: Do you have experience working remotely? ###");
//         //     examples.Add("Yes, I am currently working remotely and I have also worked remotely in the past.");
//         //     examples.Add("### QUERY: Do you have experience working remotely? ###" +
//         //                 "### ALLOWED-RESPONSES: Yes, No ###");
//         //     examples.Add("Yes");
//         //     prompt = $"### QUERY: {query} ###" + (choices.Count() > 0 ? $" ALLOWED-RESPONSES: {String.Join(", ", choices)} ###" : "");

//         // }


//         public async Task WriteProfileToVectorDB()
//         {

//             using var pinecone = new PineconeClient(Options.PineconeAPIKey);

//             await TraversePropertiesAndCreateVector(_profile, _profile.IndexClusterId, pinecone);

//         }

//         public async Task TraversePropertiesAndCreateVector(object obj, string indexClusterId, PineconeClient? pinecone)
//         {
//             if (obj == null)
//                 return;

//             //pinecone.DescribeCollection(indexClusterId);
//             Type type = obj.GetType();
//             PropertyInfo[] properties = type.GetProperties();

//             foreach (PropertyInfo property in properties)
//             {
//                 var propertyName = property.Name;
//                 if (propertyName == "Id")
//                     continue;
//                 if (propertyName == "Password")
//                     continue;
//                 if (propertyName == "IndexClusterId")
//                     continue;
//                 if (propertyName == "ProfileName")
//                     continue;
//                 if (propertyName == "CVPath")
//                     continue;
//                 if (propertyName == "CoverLetterPath")
//                     continue;
//                 if (propertyName == "TargetNumberOfApplications")
//                     continue;
//                 if (propertyName == "CreatedDate")
//                     continue;
//                 if (propertyName == "UpdatedDate")
//                     continue;
//                 if (propertyName == "ProfileLanguage")
//                     continue;
//                 if (propertyName == "TargetJobLanguages")
//                     continue;
//                 if (propertyName == "Speed")
//                     continue;
//                 if (propertyName == "Depth")
//                     continue;

//                 object value = property.GetValue(obj);

//                 if (propertyName == "Filter")
//                 {
//                     value = value?.GetType().GetProperty("SalaryExpectationsAnnually")?.GetValue(value)?.ToString();
//                     propertyName = "SalaryExpectationsAnnually";
//                 }
//                 if (propertyName == "SkillsAndRespectiveYearsOfExperience")
//                 {
//                     // value = value as IEnumerable<Skill>;
//                     // if (value is IEnumerable<Skill> skills)
//                     // {
//                     //     value = skills?.Select(skill => new { skill.Key, skill.Value }).ToList();
//                     // }
//                 }
//                 if (propertyName == "JobExperiences")
//                 {
//                     // value = value as IEnumerable<DeclaredExperience>;
//                     // if (value is IEnumerable<DeclaredExperience> experiences)
//                     // {
//                     //     value = experiences?.Select(experience => new
//                     //     {
//                     //         experience.CompanyName,
//                     //         experience.CurrentlyWorkHere,
//                     //         experience.Description,
//                     //         experience.City,
//                     //         experience.FromMonth,
//                     //         experience.FromYear,
//                     //         experience.ToMonth,
//                     //         experience.ToYear,
//                     //         experience.Title

//                     //     }).ToList();
//                     // }
//                 }

//                 if (TypeUtilities.IsDefaultForType(value))
//                     continue;

//                 var stringToEmbed = propertyName + " : " + JsonSerializer.Serialize(value, new JsonSerializerOptions { WriteIndented = true });

//                 var responseEmbedding = await EmbedValue(stringToEmbed);


//                 await AddVectorToIndex(responseEmbedding, pinecone, propertyName);

//                 ////not reaching for nested sub properties. only 1st level properties will be vectorized
//                 //if (value != null && property.PropertyType.Namespace.StartsWith("Domain.Models"))
//                 //{
//                 //    TraversePropertiesAndCreateVector(value, indexClusterId, pinecone);
//                 //}

//                 Console.WriteLine($"{propertyName}: {JsonSerializer.Serialize(value, new JsonSerializerOptions { WriteIndented = true })}");
//             }
//         }

    

//         //PINECONE

//         public async Task<EmbeddingsResponse> EmbedValue(string value)
//         {
//             using var openAI = new OpenAIClient(Options.OpenAIKey);
//             var embeddingsRequest = new EmbeddingsRequest(value, Model.Embedding_Ada_002);
//             return await openAI.EmbeddingsEndpoint.CreateEmbeddingAsync(embeddingsRequest);
//         }

//         public async Task AddVectorToIndex(EmbeddingsResponse responseEmbedding, PineconeClient pinecone, string propertyName)
//         {
//             string typeGuid = _profile.GetType().GUID.ToString();


//             var embeddings = responseEmbedding.Data.Select(x => x.Embedding).ToList();

//             if (String.IsNullOrEmpty(_profile.IndexClusterId))
//             {
//                 var indexClusterId = Guid.NewGuid().ToString();
               
//                 await pinecone.CreateServerlessIndex(indexClusterId, 1536, Metric.Cosine, Options.PineconeCloud, Options.PineconeRegion);
//                 var wasIndexCreated = (await pinecone.ListIndexes()).Select(index => index.Name).Contains(indexClusterId);
//                 if (wasIndexCreated)
//                 {
//                     _profile.IndexClusterId = indexClusterId;
//                     //write indexClusterId to User.Profile
//                 }
//             }

//             string propUniqueId = $"{_profile.IndexClusterId}_{typeGuid}_{propertyName}";
//             float[] embeddingsFloatArray = ConvertToFloatArray(embeddings);

//             if (_index == null || _index == default)
//             {
//                 _index = await pinecone.GetIndex(_profile.IndexClusterId);
//             }

//             var vectors = new[]
//             {
//             new Vector
//             {
//                 Id = propUniqueId,
//                 Values = embeddingsFloatArray,
//                 Metadata = new MetadataMap
//                 {
//                     ["text_value"] = propertyName.ToString()
//                 }
//             }
//         };

//             var upsertedCount = await _index.Upsert(vectors, _profile.IndexClusterId);

//             if (upsertedCount == 0)
//             {
//                 Console.WriteLine("Vector not upserted");
//             }
//             else
//             {
//                 Console.WriteLine($"Vector for {propertyName} upserted!");
//             }

//         }

//         private static float[] ConvertToFloatArray(List<IReadOnlyList<double>> embeddings)
//         {
//             return embeddings
//             .SelectMany(innerList => innerList.Select(value => (float)value))
//             .ToArray();
//         }

//         public async Task<ScoredVector[]> QueryIndex(EmbeddingsResponse responseEmbedding, PineconeClient pinecone, string query)
//         {
//             var embeddings = responseEmbedding.Data.Select(x => x.Embedding).ToList();

//             float[] embeddingsFloatArray = ConvertToFloatArray(embeddings);

//             var vectorId = Guid.NewGuid().ToString();

//             var vectors = new[]
//             {
//             new Vector
//             {
//                 Id = vectorId,
//                 Values = embeddingsFloatArray
//             }
//     };

//             if (_index == null || _index == default)
//             {
//                 _index = await pinecone.GetIndex(_profile.IndexClusterId);
//                 Thread.Sleep(5000);
//             }

//             //var upsertedCount = await _index.Upsert(vectors, _profile.IndexClusterId);

//             var responses = await _index.Query(vectorId, topK: 5, includeValues: true, includeMetadata: false, indexNamespace: _profile.IndexClusterId);

//             return responses;

//         }

//     }
// }