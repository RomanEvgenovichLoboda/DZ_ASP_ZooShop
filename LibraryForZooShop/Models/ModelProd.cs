using DZ_ASP_ZooShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryForZooShop.Models
{
    public class ModelProd
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
