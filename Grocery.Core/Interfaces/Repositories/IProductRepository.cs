using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product? Get(int id);
        Product Add(Product item);
        Product? Delete(Product item);
        Product? Update(Product item);
    }
}