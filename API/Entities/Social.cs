using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Social
    {
        public int Id { get; set; }
        public string? Website { get; set; }
        public string? Telegram { get; set; }
        public string? Github { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? LinkedIn { get; set; }
        public string? Twitter { get; set; }
          // Foreign key to the AppUser
        public int AppUserId { get; set; }

        // Navigation property to the AppUser entity
        public AppUser AppUser { get; set; }

    }
}