using Cardapio.Entities;
using static MudBlazor.CategoryTypes;
namespace Cardapio.Services
{
    public class CartService
    {
        public event Action? OnChange;
        private List<CartItem> Items = new();

        
        public void AddItem(CartItem item)
        {
            Items.Add(item);
            OnChange?.Invoke();
        }

        public void RemoveItem(CartItem item)
        {
            Items.Remove(item);
            OnChange?.Invoke();
        }

        public void EditItem(CartItem addItem, CartItem removeItem)
        {
            Items.Remove(removeItem);
            Items.Add(addItem);
            OnChange?.Invoke();
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(o => o.Price);
        }

        public int GetTotalItemsQuantity()
        {
            return Items.Count();
        }

        public List<CartItem> GetItems()
        {
            return Items;
        }
    }
}
