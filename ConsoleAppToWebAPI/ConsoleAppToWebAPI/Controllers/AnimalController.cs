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
    public class AnimalController : ControllerBase
    {
        private List<AnimalModel> Animals = null;

        public AnimalController()
        {
            this.Animals = new List<AnimalModel>()
            {
                new AnimalModel { Id = 1, Name = "Cat" },
                new AnimalModel { Id = 2, Name = "Kitten" }
            };
        }

        public IActionResult GetAnimals()
        {
            return Ok("all animals");
        }

        [Route("test", Name ="All")]
        public IActionResult GetAnimalsTest()
        {
            List<AnimalModel> animals = new List<AnimalModel>()
            {
                new AnimalModel { Id = 1, Name = "Cat" },
                new AnimalModel { Id = 2, Name = "Kitten" }
            };
            //return Accepted("~/api/animal");  //by url
            // return AcceptedAtAction("GetAnimalsTest"); // by acction method name
            return AcceptedAtRoute("All"); // by route name
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(Animals);
        }

        [Route("{id}")]
        public IActionResult GetAnimalsById(int Id)
        {
            if (Id == 0)
            {
                return BadRequest();
            }
            return Ok(Animals.FirstOrDefault(x => x.Id == Id));
        }

        [HttpPost("")]
        public IActionResult GetAnimal(AnimalModel animal)
        {
            Animals.Add(animal);
            return Created("~/api/animal", new { id = animal.Id });  // arg should be an url to created resource
        }
    }
}
