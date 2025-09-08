namespace Grocery.Core.Models
{
    public class GroceryListItem : Model
    {
        // Properties in plaats van member variabelen
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }

        public Product Product { get; set; } = new(0, "None", 0);

        // Constructor
        public GroceryListItem(int id, int groceryListId, int productId, int amount) 
            : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;
        }
    }
}