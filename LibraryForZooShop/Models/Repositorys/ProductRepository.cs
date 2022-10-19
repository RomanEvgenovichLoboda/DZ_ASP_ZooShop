using DZ_ASP_ZooShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForZooShop.Models.Repositorys
{
    public static class ProductRepository
    {
        public static string AddOneProduct(string prodName,string animalName)
        {
            ProductContext context = new ProductContext();
            foreach (var item in context.Products)
            {
                if (prodName.ToLower() == item.Name.ToLower()) return "Has already!";
            }
            int?id = context.Animals.FirstOrDefault(e => e.Name.ToLower() == animalName.ToLower())?.Id;
            Product pr = new Product();
            pr.Name = prodName;
            if (id == null)
            {
                pr.Animal = new Animal();
                pr.Animal.Name = animalName;
            }
            else pr.AnimalId = (int)id;
            context.Products.Add(pr);
            context.SaveChanges();
            return "Added!";
        }
        public static IEnumerable<Product> GetAllProducts() => new ProductContext().Products;
    }
}
