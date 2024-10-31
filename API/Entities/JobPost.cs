using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities.Enums;

namespace API.Entities
{
    public class JobPost
    {
        public int Id { get; set; }
        public DateTime CreatedDateUtc { get; set; }
        public DateTime UpdatedDateUtc { get; set; }
        public AppUser CreatedBy { get; set; }
        public ICollection<AppUser> Candidates { get; set; } = new List<AppUser>();
        public AppUser? SelectedCandidate { get; set; }
        public string? ApplyUrl { get; set; }
        public string? Position { get; set; }
        public string? Description { get; set; }
        public string? HowToApply { get; set; }
        public string? CompanyName { get; set; }
        public string? CompanyUrl { get; set; }
        public OnSiteRemoteHybrid OnSiteRemoteHybrid { get; set; }
        public string? PayRange { get; set; }
        public string? Salary { get; set; }
        public string? Currency { get; set; }
        public bool? IsUnder10Applicants { get; set; }
        public string? ProcessPhase { get; set; }
        public string? Industry { get; set; }
        public bool? IsReposted { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateReposted { get; set; }
        public int? NumberOfApplicants { get; set; }
        public int? NumberOfViews { get; set; }
        public bool? IsEasyApply { get; set; }
        public int? NumberOfCompanyEmployees { get; set; }
        public int? NumberOfTeamMembers { get; set; }
        public string? Methodology { get; set; }
        public bool? IsActivelyRecruiting { get; set; }
        public bool? IsComplete { get; set; }
        public bool? IsPromoted { get; set; }
       
        public JobType? JobType { get; set; }
        public ExperienceLevel? ExperienceLevel { get; set; }

        public string? Locations { get; set; }  // a stringified list of locations 
        public ICollection<Benefit> Benefits { get; set; } = new List<Benefit>();  // Job-specific locations
        public string? MainCountry { get; set; }
        public string? MainCity { get; set; }
        
        public ICollection<Document> Documents { get; set; }
        public ICollection<JobPostSkill> Skills { get; set; } = new List<JobPostSkill>();
        public ICollection<JobPostLanguage> Languages { get; set; } = new List<JobPostLanguage>();
        public string? PreferedTimezones { get; set; } //a stringified list of timezones, e.g., "UTC+1,UTC+2"

        

        public string? ImageLogoUrl { get; set; }
        public string? CompanyEmail { get; set; }
        public string? InvoiceEmail { get; set; }
        public string? InvoiceAddress { get; set; }
        public string? InvoiceNotes { get; set; }
        public string? FeedbackAboutWebsite { get; set; }
        public string? ProfileMinifiedUrl { get; set; }

        //LLM
        public string? IndexClusterId { get; set; }  // Index cluster ID for Pinecone
        public bool? IsOnAutoMessage { get; set; }
        public bool? IsOnAutoSelection { get; set; }
    }

    public class JobPostLanguage
    {
        public int Id { get; set; }
        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }

    public class JobPostSkill
    {
        public int Id { get; set; }
        public int JobPostId { get; set; }
        public JobPost JobPost { get; set; }
        public int SkillId { get; set; }
        public Skill Skill { get; set; }
    }

     public class JobPostBenefit
     {
            public int Id { get; set; }
            public int JobPostId { get; set; }
            public JobPost JobPost { get; set; }
            public int BenefitId { get; set; }
            public Benefit Benefit { get; set; }
     }



    // public List<City>? Cities { get; set; } = new List<City>();  // Job-specific locations
    // public List<Country>? Countries { get; set; } = new List<Country>();  // Job-specific locations
    // public List<ContinentAndWorld>? ContinentsAndWorldwide { get; set; } = new List<ContinentAndWorld>();// Job-specific locations
    // public class ContinentAndWorld : StringProperty;
    // public class Country : StringProperty;
    // public class City : StringProperty;
  
}