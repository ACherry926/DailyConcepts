using Day26Concepts.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day26Concepts.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals = null;
        public AnimalsController()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name ="Dog"},
                new AnimalModel() {Id = 2, Name ="Lion"}
            };
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetAnimals()
        {
            var animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name ="Dog"},
                new AnimalModel() {Id = 2, Name ="Lion"}
            };
            return Ok(animals);
        }

        [HttpGet]
        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            return Accepted(animals);
        }


        //[HttpGet]
        //[Route("test")]
        //public IActionResult GetAnimalsTests()
        //{
        //    return Accepted("~/api/animals");
        //}

        [HttpGet]
        [Route("test1")]
        public IActionResult GetAnimalsTest1()
        {
            return AcceptedAtAction("GetAnimals");
        }

        //[HttpGet]
        //[Route("", Name = "All")]
        //public IActionResult GetAnimal()
        //{
        //    return Ok(animal);
        //}

        [HttpGet]
        [Route("test2")]
        public IActionResult GetAnimalsTest2()
        {
            return AcceptedAtRoute("All");
        }

        [HttpGet]
        [Route("{name}")]
        public IActionResult GetAnimalByName(string name)
        {
            if (!name.Contains("ABC"))
            {
                return BadRequest();
            }
            return Ok(animals);
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return Ok(animals.FirstOrDefault(animal => animal.Id == id));
        }

        //[HttpPost("")]
        //public IActionResult GetAnimal(AnimalModel animal)
        //{
        //    return Created("~/api/animals", new { id = animal.Id });
        //}

        [HttpPost("")]
        public IActionResult GetAnimal(AnimalModel animal)
        {
            animals.Add(animal);
            return Created("~/api/animal" + animal.Id, animal);
        }

        //[HttpGet]
        //[Route("test")]
        //public IActionResult GetAnimalsTest()
        //{
        //    return LocalRedirect("~/api/animal");
        //}

        //[HttpPost("")]
        //public IActionResult GetAnimals(AnimalModel animal)
        //{
        //    animals.Add(animal);
        //    return CreatedAtAction("GetAnimalById", new { id = animal.Id }, animal);
        //}
    }
}
