using DZ_ASP_ZooShop.Models;
using LibraryForZooShop.Models;
using LibraryForZooShop.Models.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClothingController
    {
        [HttpGet("GetAllClothings")]
        public IEnumerable<Clothing> GetAllClothings()
        {
            return (IEnumerable<Clothing>)ProductRepository.GetAllProducts(new Clothing());
        }
        [HttpPost("AddOneClothing")]
        public string AddOneClothing(string prod, string anim, double _price)
        {
            return ProductRepository.AddOneProduct(prod, anim, _price, new Clothing());
        }
    }
}
