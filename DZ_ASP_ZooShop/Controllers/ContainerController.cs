using LibraryForZooShop.Models.Repositorys;
using LibraryForZooShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContainerController
    {
        [HttpGet("GetAllContainers")]
        public IEnumerable<Container> GetAllContainers()
        {
            return (IEnumerable<Container>)ProductRepository.GetAllProducts(new Container());
        }
        [HttpPost("AddOneContainer")]
        public string AddOneContainer(string prod, string anim, double _price)
        {
            return ProductRepository.AddOneProduct(prod, anim, _price, new Container());
        }
    }
}
