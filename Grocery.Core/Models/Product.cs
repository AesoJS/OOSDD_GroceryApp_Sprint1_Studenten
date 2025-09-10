namespace Grocery.Core.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }

        public Product(int id, string name, int stock)
        {
            Id = id;
            Name = name;
            Stock = stock;
        }
    }
}