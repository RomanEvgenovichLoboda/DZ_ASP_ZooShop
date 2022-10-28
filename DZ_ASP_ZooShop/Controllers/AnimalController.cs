using DZ_ASP_ZooShop.Models;
using LibraryForZooShop.Models.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController
    {
       // AnimalRepository animalRepository = new AnimalRepository();
        [HttpGet("GetAllAnimals")]
        public IEnumerable<Animal> GetAllAnimals()
        {
            return AnimalRepository.GetAllAnimals();
        }
        //[HttpPost("AddOneAnimals")]
        //public string AddOneAnimals(string anim)
        //{
        //    return AnimalRepository.AddOneAnimal(anim);
        //}
        [HttpPost("AddOneAnimal")]
        public string AddOneAnimal([FromForm]Animal anim)
        {
            return AnimalRepository.AddOneAnimal(anim);
        }
    }
}
