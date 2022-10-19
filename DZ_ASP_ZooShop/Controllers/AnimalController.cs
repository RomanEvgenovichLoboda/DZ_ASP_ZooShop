using DZ_ASP_ZooShop.Models;
using LibraryForZooShop.Models.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AnimalController
    {
        [HttpGet("GetAllAnimals")]
        public IEnumerable<Animal> GetAllAnimals()
        {
            return AnimalRepository.GetAllAnimals();
        }
        [HttpPost("AddOneAnimals")]
        public string AddOneAnimals(string anim)
        {
            return AnimalRepository.AddOneAnimal(anim);
        }
    }
}
