using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public ICollection<UserLanguage> UserLanguages { get; set; } = new List<UserLanguage>();
        public ICollection<JobPostLanguage> JobPostLanguages { get; set; } = new List<JobPostLanguage>();

    }
}