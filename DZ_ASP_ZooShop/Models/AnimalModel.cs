namespace DZ_ASP_ZooShop.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
