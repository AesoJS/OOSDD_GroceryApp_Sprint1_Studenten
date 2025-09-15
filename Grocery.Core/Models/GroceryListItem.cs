namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        // Navigatieproperty zodat je productinfo kunt ophalen
        public Product Product { get; set; }

        public GroceryListItem(int id, int groceryListId, int productId, int amount, Product? product = null)
            : base(id, product?.Name ?? "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
            Product = product ?? new Product(0, "Onbekend", 0);
        }
    }
}