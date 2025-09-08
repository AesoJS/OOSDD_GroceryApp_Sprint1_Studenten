using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Grocery.Core.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly List<Product> _products;

        public ProductRepository()
        {
            // Initialiseer de lijst met 4 producten
            _products = new List<Product>
            {
                new Product(1, "Melk", 300),
                new Product(2, "Kaas", 100),
                new Product(3, "Brood", 400),
                new Product(4, "Cornflakes", 0)
            };
        }

        // Haal alle producten op
        public List<Product> GetAll()
        {
            return _products;
        }

        // Haal een product op basis van ID
        public Product? Get(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        // Voeg een product toe (nog niet geïmplementeerd)
        public Product Add(Product item)
        {
            throw new NotImplementedException();
        }

        // Verwijder een product (nog niet geïmplementeerd)
        public Product? Delete(Product item)
        {
            throw new NotImplementedException();
        }

        // Update een product (nog niet geïmplementeerd)
        public Product? Update(Product item)
        {
            throw new NotImplementedException();
        }
    }
}