using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public sealed class AuthMessageSenderOptions
    {
         public string SendGridKey { get; set; }
         public string SupportEmail { get; set; }
    }
}