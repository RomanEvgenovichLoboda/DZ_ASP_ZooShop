using LibraryForZooShop.Models.Repositorys;
using LibraryForZooShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToyController
    {
        [HttpGet("GetAllToys")]
        public IEnumerable<Toy> GetAllToys()
        {
            return (IEnumerable<Toy>)ProductRepository.GetAllProducts(new Toy());
        }
        [HttpPost("AddOneToy")]
        public string AddOneToy([FromForm]Data data)
        {
            return ProductRepository.AddOneProduct(data.Product, data.Animal, data.Price, new Toy());
        }
        //public string AddOneToy(string prod, string anim, double _price)
        //{
        //    return ProductRepository.AddOneProduct(prod, anim, _price, new Toy());
        //}
    }
    

}
