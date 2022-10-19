using DZ_ASP_ZooShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController
    {
        [HttpGet("GetAllProducts")]
        public IEnumerable<Product> GetAllProductss()
        {
            ProductContext context = new ProductContext();
            return context.Products;
        }
        [HttpPost("AddOneProduct")]
        public string AddOneProduct(string prod, string anim)
        {
            Product pr = new Product();
            pr.Name = prod;
            pr.Animal = new Animal();
            pr.Animal.Name = anim;
            ProductContext context = new ProductContext();
            context.Products.Add(pr);
            context.SaveChanges();
            return "Added!";//context.Products;

        }
    }
}
