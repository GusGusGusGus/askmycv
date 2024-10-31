using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }  // e.g., "New York", "San Francisco"
        public string Country { get; set; }  // e.g., "New York", "San Francisco"
        public string TimeZoneIANA { get; set; }    // IANA Time Zone ID e.g. "America/New_York"
    }
}