using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;
using System.Collections.ObjectModel;

namespace Grocery.App.ViewModels
{
    public class ProductViewModel : BaseViewModel
    {
        public ObservableCollection<Product> Products { get; set; } = new();

        public ProductViewModel(IProductService productService)
        {
            var productList = productService.GetAll() ?? new List<Product>();
            foreach (var p in productList)
            {
                Products.Add(p);
            }
        }
    }
}