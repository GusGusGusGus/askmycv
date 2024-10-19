using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class BlobStorageOptions
    {
        public string ConnectionString { get; set; }
        public string ContainerName { get; set; }
    }
}