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
        public static string AddOneProduct(string prodName,string animalName, double _price, ModelProd pr)
        {
            ProductContext context = new ProductContext();

            IEnumerable<ModelProd> list = new List<ModelProd>();
            if (pr.GetType() == typeof(Product)) list = context.Products;
            else if (pr.GetType() == typeof(Clothing)) list = context.Clothings;
            else if (pr.GetType() == typeof(Medicine)) list = context.Medicines;
            else if (pr.GetType() == typeof(Toy)) list = context.Toys;
            else if (pr.GetType() == typeof(Container)) list = context.Containers;
            else if (pr.GetType() == typeof(Building)) list = context.Buildings;

            foreach (var item in list) { if (prodName.ToLower() == item.Name.ToLower()) return "Has already!"; }

            int?id = context.Animals.FirstOrDefault(e => e.Name.ToLower() == animalName.ToLower())?.Id;
            //Product pr = new Product();
            pr.Name = prodName;
            pr.Price = _price;
            if (id == null)
            {
                pr.Animal = new Animal();
                pr.Animal.Name = animalName;
            }
            else pr.AnimalId = (int)id;
            if(pr.GetType() == typeof(Product)) context.Products.Add((Product)pr);
            else if (pr.GetType() == typeof(Clothing)) context.Clothings.Add((Clothing)pr);
            else if (pr.GetType() == typeof(Medicine)) context.Medicines.Add((Medicine)pr);
            else if (pr.GetType() == typeof(Toy)) context.Toys.Add((Toy)pr);
            else if (pr.GetType() == typeof(Container)) context.Containers.Add((Container)pr);
            else if (pr.GetType() == typeof(Building)) context.Buildings.Add((Building)pr);
            context.SaveChanges();
            return "Added!";
        }
        public static IEnumerable<ModelProd> GetAllProducts(ModelProd pr) 
        {
            if (pr.GetType() == typeof(Product)) return new ProductContext().Products;
            else if (pr.GetType() == typeof(Clothing)) return new ProductContext().Clothings;
            else if (pr.GetType() == typeof(Medicine)) return new ProductContext().Medicines;
            else if (pr.GetType() == typeof(Toy)) return new ProductContext().Toys;
            else if (pr.GetType() == typeof(Container)) return new ProductContext().Containers;
            else if (pr.GetType() == typeof(Building)) return new ProductContext().Buildings;
            else return null;
        }
    }
}
