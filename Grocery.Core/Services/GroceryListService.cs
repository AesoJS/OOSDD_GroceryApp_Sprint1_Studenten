using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services
{
    public class GroceryListService : IGroceryListService
    {
        private readonly IGroceryListRepository _groceryRepository;

        public GroceryListService(IGroceryListRepository groceryRepository)
        {
            _groceryRepository = groceryRepository;
        }

        public List<GroceryList> GetAll()
        {
            return _groceryRepository.GetAll();
        }

        public GroceryList? Get(int id)
        {
            return _groceryRepository.Get(id);
        }

        public GroceryList Add(GroceryList item)
        {
            return _groceryRepository.Add(item);
        }

        public GroceryList? Update(GroceryList item)
        {
            return _groceryRepository.Update(item);
        }

        public GroceryList? Delete(GroceryList item)
        {
            return _groceryRepository.Delete(item);
        }

        /// <summary>
        /// Voeg een product toe aan een boodschappenlijst.
        /// - Alleen als er voorraad is.
        /// - Koppelt automatisch met GroceryListId en ProductId.
        /// - Vermindert de voorraad in Product.
        /// </summary>
        public void AddProduct(GroceryList list, Product product)
        {
            if (product.Stock <= 0) return;

            var item = new GroceryListItem(
                id: list.Items.Count + 1,   // uniek id binnen de lijst
                groceryListId: list.Id,     // koppel item aan deze boodschappenlijst
                productId: product.Id,      // koppel item aan product
                amount: 1,                  // begin met 1 stuks
                product: product            // sla ook het Product-object zelf op
            );

            list.Items.Add(item);

            product.Stock--; // voorraad verminderen
        }
    }
}