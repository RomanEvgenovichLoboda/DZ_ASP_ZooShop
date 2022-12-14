using LibraryForZooShop.Models;
using System.Collections.Generic;

namespace DZ_ASP_ZooShop.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new();
        public List<Clothing> Clothings { get; set; } = new();
        public List<Medicine> Medicines { get; set; } = new();
        public List<Toy> Toys { get; set; } = new();
        public List<Container> Containers { get; set; } = new();
        public List<Building> Buildings { get; set; } = new();
    }
}
