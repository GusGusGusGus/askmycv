using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Entities.Enums
{
    public enum JobType
    {
        None = 0,
        FullTime,
        PartTime,
        Contract,
        Temporary,
        Volunteer,
        Internship,
        Other
    }
}