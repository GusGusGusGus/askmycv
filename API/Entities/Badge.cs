using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Badge
    {
        public int Id { get; set; }
        public string BadgeName { get; set; }
        public string? BadgeDescription { get; set; }
        public string? BadgeIcon { get; set; }
    }
}