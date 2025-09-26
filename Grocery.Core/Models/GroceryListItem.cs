using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models
{
    public partial class GroceryListItem : Model
    {
        public int GroceryListId { get; set; }
        public int ProductId { get; set; }

        [ObservableProperty]
        private int amount;

        [ObservableProperty]
        private bool isPurchased;

        public GroceryListItem(int id, int groceryListId, int productId, int amount) : base(id, "")
        {
            GroceryListId = groceryListId;
            ProductId = productId;
            Amount = amount;  // Hoofdletter A! Dit wordt automatisch gegenereerd
            IsPurchased = false;  // Hoofdletter I!
        }

        public Product Product { get; set; } = new(0, "None", 0);
    }
}