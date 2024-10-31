using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
     public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public string? Proficiency { get; set; }
        public ICollection<UserSkill> UserSkills { get; set; } = new List<UserSkill>();
        public ICollection<JobPostSkill> JobPostSkills { get; set; } = new List<JobPostSkill>();
    }
}