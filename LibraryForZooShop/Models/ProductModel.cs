namespace DZ_ASP_ZooShop.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AnimalId { get; set; }
        public Animal Animal { get; set; }
    }
}
