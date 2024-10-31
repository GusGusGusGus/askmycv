using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Education
    {
        public int Id { get; set; }

       public int YearStart { get; set; }
        [Range(1, 12)]
        public int MonthStart { get; set; } // 1 to 12
        public int? YearEnd { get; set; }
        [Range(1, 12)]
        public int? MonthEnd { get; set; } // 1 to 12

        public string Title { get; set; }

        public string InstitutionName { get; set; }
        public string? CourseName { get; set; }
        public string Url { get; set; }
        public bool? IsOngoing { get; set; }
            // Foreign key to the AppUser
        public int AppUserId { get; set; }

        // Navigation property to the AppUser entity
        public AppUser AppUser { get; set; }

    }
}