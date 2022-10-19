using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace DZ_ASP_ZooShop.Models
{
    public class ProductContext: DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Animal> Animals { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            new ConfigurationBuilder().AddUserSecrets<ProductContext>()
                .Build()
                .Providers
                .First()
                .TryGet("connStr", out var connStr);
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
