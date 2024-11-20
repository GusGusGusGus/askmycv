using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Intefaces
{
    public interface ILLMProvider
    {
        Task<string> GetResponseAsync(string prompt);
    }
}