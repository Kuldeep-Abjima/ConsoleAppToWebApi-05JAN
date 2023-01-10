using ConsoleAppToWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleAppToWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
             animals = new List<AnimalModel>() 
          
            { 
                new AnimalModel() { Id = 1, Name = "dog" },
                new AnimalModel() { Id = 2, Name = "cat"} 
            
            };

        }
        //[Route("")]
        [Route("", Name = "all")]
        public IActionResult GetAnimals()
        {
            //var animals = new List<AnimalModel>() { new AnimalModel() { Id = 1, Name = "dog" },
            //new AnimalModel() { Id = 2, Name = "cat"} };
            return Ok(animals);
        }
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {

            return LocalRedirect("~/api/animals");
        }
        //[Route("test")]
        //public IActionResult GetAnimalsTest()
        //{
        //    //var animals = new List<AnimalModel>() { new AnimalModel() { Id = 1, Name = "dog" },
        //    //new AnimalModel() { Id = 2, Name = "cat"} };
        //    //return Accepted("~/api/animals");
        //    //return AcceptedAtAction("GetAnimals");
        //    return AcceptedAtRoute("all");
        //}
        
        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }
        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var animal = animals.FirstOrDefault(x => x.Id == id);
            if (animal == null)
            {
                return NotFound();
            }
            return Ok(animals);
        }
        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
         
            animals.Add(animal);
            //return Created("~/api/animals"+animal.Id ,animal/*new{ id = animal.Id}*/);
            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal/*new{ id = animal.Id}*/);

        }

    }
}
