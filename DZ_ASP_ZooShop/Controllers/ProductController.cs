using DZ_ASP_ZooShop.Models;
using LibraryForZooShop.Models.Repositorys;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        [HttpGet("GetAllProducts")]
        public IEnumerable<Product> GetAllProducts()
        {
            return (IEnumerable<Product>)ProductRepository.GetAllProducts(new Product());
        }
        [HttpPost("AddOneProduct")]
        public string AddOneProduct(string prod, string anim, double _price)
        {
            return ProductRepository.AddOneProduct(prod, anim, _price,new Product());
        }
    }
}
