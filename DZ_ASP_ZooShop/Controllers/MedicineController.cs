using LibraryForZooShop.Models.Repositorys;
using LibraryForZooShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace DZ_ASP_ZooShop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MedicineController
    {
        [HttpGet("GetAllMedicines")]
        public IEnumerable<Medicine> GetAllMedicines()
        {
            return (IEnumerable<Medicine>)ProductRepository.GetAllProducts(new Medicine());
        }
        [HttpPost("AddOneMedicine")]
        public string AddOneMedicine(string prod, string anim, double _price)
        {
            return ProductRepository.AddOneProduct(prod, anim, _price, new Medicine());
        }
    }
}
