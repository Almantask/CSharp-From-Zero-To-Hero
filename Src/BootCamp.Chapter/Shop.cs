using System;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal GetMoney()
        {
            return _money;
        }

        private Inventory _inventory = new Inventory();

        public Shop()
        {
        }

        public Shop(decimal money)
        {
            _money = money;
        }

        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            var existingItems = _inventory.GetItems(item.GetName());
            if (existingItems.Length > 0)
            {
                return;
            }
            
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            var items = _inventory.GetItems(name);

            if (items.Length == 0)
            {
                return;
            }
            
            _inventory.RemoveItem(items[0]);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop loses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            _inventory.AddItem(item);

            var itemPrice = item.GetPrice();

            if (itemPrice > _money)
            {
                return 0;
            }
            
            _money -= itemPrice;
            
            return itemPrice;
        }

        /// <summary>
        /// Sell item from a shop.
        /// Shop increases it's money.
        /// No money is increased if item does not exist.
        /// </summary>
        /// <returns>
        /// Item sold.
        /// Null, if no item is sold.
        /// </returns>
        public Item Sell(string item)
        {
            var items = _inventory.GetItems(item);
            if (items.Length == 0)
            {
                return null;
            }

            _money += items[0].GetPrice();
            
            return items[0];
        }
    }
}