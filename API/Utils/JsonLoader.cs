using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using API.Entities;

namespace API.Utils
{
    public class JsonLoader
    {
        public static List<Location> LoadLocationsFromJson(string path)
        {
            using (StreamReader r = new StreamReader(path))
            {
                string json = r.ReadToEnd();
                return JsonSerializer.Deserialize<List<Location>>(json);
            }
        }
    }
}