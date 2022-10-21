using LibraryForZooShop.Models;
using System.Collections.Generic;

namespace DZ_ASP_ZooShop.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public List<Clothing> Clothings { get; set; }
        public List<Medicine> Medicines { get; set; }
        public List<Toy> Toys { get; set; }
    }
}
