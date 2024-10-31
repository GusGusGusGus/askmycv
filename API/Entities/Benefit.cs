using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities
{
    public class Benefit
    {
        public int Id { get; set; }
        public string BenefitName { get; set; }
        public ICollection<JobPostBenefit> JobPostBenefits { get; set; } = new List<JobPostBenefit>();
    }

   
}