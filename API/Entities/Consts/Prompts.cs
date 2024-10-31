using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Consts
{
    public class Prompts
    {
        internal const string SYSTEM_PROMPT_Routing = @"
        You are a RAG router that determines the most appropriate action based on user input.
        You MUST respond with ONLY a JSON object in the following exact format:

        {
            ""action"": string,        // Must be one of: [""Search"", ""Write"", ""Analyze"", ""Calculate""]
            ""confidence"": number,    // Value between 0 and 1
            ""reasoning"": string,     // Brief explanation of why this action was chosen
            ""parameters"": {          // Dictionary of relevant parameters for the action
                ""key1"": ""value1"",
                ""key2"": ""value2""
            }
        }

        Example response:
        {
            ""action"": ""Search"",
            ""confidence"": 0.92,
            ""reasoning"": ""User is explicitly asking to find information about a specific topic"",
            ""parameters"": {
                ""query"": ""machine learning basics"",
                ""scope"": ""technical documentation""
            }
        }

        DO NOT include any other text or explanations outside of this JSON structure.
        ENSURE all string values are properly escaped.
        ALWAYS include all required fields (action, confidence, reasoning, parameters).
        ";


    }
}