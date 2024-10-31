using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Entities
{
    public class RoutingResponse
    {
         [JsonPropertyName("action")]
        public string Action { get; set; }

        [JsonPropertyName("confidence")]
        public double Confidence { get; set; }

        [JsonPropertyName("reasoning")]
        public string Reasoning { get; set; }

        [JsonPropertyName("parameters")]
        public Dictionary<string, string> Parameters { get; set; }
    }
}