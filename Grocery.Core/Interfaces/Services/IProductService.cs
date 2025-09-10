using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product Add(Product item);
        Product? Delete(Product item);
        Product? Get(int id);
        Product? Update(Product item);
    }
}