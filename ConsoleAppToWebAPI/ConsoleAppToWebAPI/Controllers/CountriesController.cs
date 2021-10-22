using ConsoleAppToWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet =true)]
    public class CountriesController : ControllerBase
    {
        
        CountryModel Country { get; set; }

        [HttpPost("")]
        public IActionResult AddCountry()
        {
            return Ok($"Name = {this.Country.Name} " + 
                $"Population = {this.Country.Population} "+ 
                $"Area = {this.Country.Area}");
        }
    }
}
