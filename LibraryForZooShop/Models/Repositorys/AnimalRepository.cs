using DZ_ASP_ZooShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryForZooShop.Models.Repositorys
{
    public static class AnimalRepository
    {
        public static IEnumerable<Animal> GetAllAnimals() => new ProductContext().Animals;
        //public static string AddOneAnimal(string name)
        //{
        //    ProductContext context = new ProductContext();
        //    foreach (var item in context.Animals)
        //    {
        //        if (item.Name.ToLower() == name.ToLower()) return "Has Already!";
        //    }
        //    Animal animal = new Animal();
        //    animal.Name = name; 
        //    context.Animals.Add(animal);
        //    context.SaveChanges();
        //    return "Added!";
        //}

        public static string AddOneAnimal(Animal animal)
        {

            ProductContext context = new ProductContext();
            foreach (var item in context.Animals)
            {
                if (item.Name.ToLower() == animal.Name.ToLower()) return "Has Already!";
            }
            context.Animals.Add(animal);
            context.SaveChanges();
            return "Added!";
        }


    }
}
