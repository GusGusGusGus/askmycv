using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public sealed class LLMOptions
    {
        public string LlamaKey { get; set; } = String.Empty;
        public string OpenAIKey { get; set; } = String.Empty;
        public string MistralKey { get; set; } = String.Empty;
        public string AnthropicKey { get; set; } = String.Empty;
        public string PineconeAPIKey { get; set; } = String.Empty;
        public string PineconeEnvironment { get; set; } = String.Empty;
        public string PineconeCloud { get; set; } = String.Empty;
        public string PineconeRegion { get; set; } = String.Empty;
        public string PineconeType { get; set; } = String.Empty;

    }
}