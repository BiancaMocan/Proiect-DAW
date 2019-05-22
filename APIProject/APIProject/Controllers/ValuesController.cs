using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using APIProject.Models;

namespace APIProject.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        public static List<Dog> dogs = new List<Dog>()
        {
            new Dog() { Id = Guid.NewGuid(), Name = "Rexi", Age = 2, Weight = 50, Breed = "Caucasian" },
            new Dog() { Id = Guid.NewGuid(), Name = "Nero", Age = 2, Weight = 40, Breed = "Chiuaua" },
        };

        // GET api/values
        [HttpGet]
        public IEnumerable<Dog> Get()
        {
            return dogs.ToArray();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Dog Get(Guid id)
        {
            return dogs.FirstOrDefault(x => x.Id == id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult PostMovie([FromBody] Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            dog.Id = Guid.NewGuid();
            dogs.Add(dog);

            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult PutDog([FromRoute] Guid id, [FromBody] Dog dog)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            Dog theDog = dogs.FirstOrDefault(x => x.Id == id);

            theDog.Name = dog.Name;
            theDog.Age = dog.Age;
            theDog.Weight = dog.Weight;
            theDog.Breed = dog.Breed;

            return Ok();
        }


        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDog([FromRoute] Guid id)
        {
            dogs.Remove(dogs.FirstOrDefault(x => x.Id == id));
            return Ok();
        }
    }
}
