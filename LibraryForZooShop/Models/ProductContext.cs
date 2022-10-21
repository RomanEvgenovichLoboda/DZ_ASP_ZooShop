using LibraryForZooShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DZ_ASP_ZooShop.Models
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Clothing> Clothings { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Toy> Toys { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //new ConfigurationBuilder().AddUserSecrets<ProductContext>()
            //    .Build()
            //    .Providers
            //    .First()
            //    .TryGet("connStr", out var connStr);
            string connStr = "Data Source=SQL5105.site4now.net;Initial Catalog=db_a8dfed_mydatabase1;User Id=db_a8dfed_mydatabase1_admin;Password=2657sgnusmas";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
