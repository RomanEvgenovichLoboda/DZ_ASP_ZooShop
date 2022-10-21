using LibraryForZooShop.Models;
using LibraryForZooShop.Models.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BuildingController
    {
        [HttpGet("GetAllBuilding")]
        public IEnumerable<Building> GetAllBuildings()
        {
            return (IEnumerable<Building>)ProductRepository.GetAllProducts(new Building());
        }
        [HttpPost("AddOneBuilding")]
        public string AddOneBuilding(string prod, string anim, double _price)
        {
            return ProductRepository.AddOneProduct(prod, anim, _price, new Building());
        }
    }
}
