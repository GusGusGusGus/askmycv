using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using API.Intefaces;
using API.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class LocationController : BaseApiController
    {
        private readonly List<Location> _locations;

        public LocationController(List<Location> locations)
        {
            _locations = locations;
            
        }


        [HttpGet("locations")]
        public ActionResult<List<Location>> GetLocations()
        {
        
            return Ok(_locations);
        }
    }
}