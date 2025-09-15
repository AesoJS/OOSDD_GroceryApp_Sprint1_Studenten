using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            _products = new List<Product>
            {
                new Product(1, "Melk", 300),
                new Product(2, "Kaas", 100),
                new Product(3, "Brood", 400),
                new Product(4, "Cornflakes", 0)
            };
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public Product? Get(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public Product Add(Product item)
        {
            _products.Add(item);
            return item;
        }

        public Product? Update(Product item)
        {
            var existing = Get(item.Id);
            if (existing == null) return null;

            existing.Name = item.Name;
            existing.Stock = item.Stock;
            return existing;
        }

        public Product? Delete(Product item)
        {
            if (_products.Remove(item))
            {
                return item;
            }
            return null;
        }

        /// <summary>
        /// Geeft beschikbare producten terug:
        /// - voorraad > 0
        /// - nog niet in de boodschappenlijst
        /// </summary>
        public List<Product> GetAvailableProducts(GroceryList list)
        {
            return _products
                .Where(p => p.Stock > 0 && !list.Items.Any(i => i.ProductId == p.Id))
                .ToList();
        }
    }
}