using API.Entities.Enums;
using Microsoft.AspNetCore.Identity;

namespace API.Entities
{
    public class AppUser : IdentityUser<int>
    {
        //Personal Info
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? IdentificationDocumentType { get; set; }
        public string? IdentificationDocumentNumber { get; set; }
        public DateTime? IdentificationDocumentValidity { get; set; }
        public string? IdentityHash { get; set; }
        public bool IsRecruiter { get; set; }  // Recruiter or Candidate

        //Location
        public string? Locations { get; set; }  // a stringified list of locations 
        public bool? isRemote { get; set; }  // Remote or not
        public string CountryOfResidency { get; set; }
        public string CityOfResidency { get; set; }


        public string? Nationality { get; set; }
        public string? Introduction { get; set; }
        public int? YearsOfExperience { get; set; }

        public DateTime DateOfBirth { get; set; }
        public string? KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string? Gender { get; set; }
        public string? Hobbies { get; set; }
        public ICollection<UserLanguage> SpokenLanguages { get; set; } = new List<UserLanguage>();
        public string? PreferedTimezones { get; set; } //a stringified list of timezones, e.g., "UTC+1,UTC+2"

        public bool? EmailNotifications { get; set; }
        public ICollection<UserBadge> Badges { get; set; } = new List<UserBadge>();
        public bool? IsAvailable { get; set; }
        public int? SalaryExpectationsAnnually { get; set; }
        public int? SalaryExpectationsHourly { get; set; }
        public int? SalaryExpectationsDaily { get; set; }
        public JobType? PreferredAgreementType { get; set; }
        public DateOnly? DateAvailable { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Document> Documents { get; set; }

        public ICollection<UserLike> LikedByUsers { get; set; }
        public ICollection<UserLike> LikedUsers { get; set; }

        public ICollection<Message> MessagesSent { get; set; }
        public ICollection<Message> MessagesReceived { get; set; }
        public ICollection<AppUserRole> UserRoles { get; set; }
        public ICollection<UserSkill> Skills { get; set; } = new List<UserSkill>();

        public List<Employment> Employments { get; set; } = new List<Employment>();
        public List<SideProject> SideProjects { get; set; } = new List<SideProject>();
        public List<Education> Education { get; set; } = new List<Education>();
        public List<Social> Socials { get; set; } = new List<Social>();
        public string? ProfileMinifiedUrl { get; set; }

        //LLM
        public string? IndexClusterId { get; set; }  // Index cluster ID for Pinecone
        public bool? IsOnAutoMessage { get; set; }
        public bool? IsOnAutoSelection { get; set; }


    }

    public class UserBadge
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int BadgeId { get; set; }
        public Badge Badge { get; set; }
    }

    public class UserLanguage
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public string? Proficiency { get; set; } // User-specific proficiency
    }

    public class UserSkill
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public string? Proficiency { get; set; } // User-specific proficiency
    }

    

    public class UserPreferedBenefit
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public int BenefitId { get; set; }
        public Benefit Benefit { get; set; }
    }


    
}