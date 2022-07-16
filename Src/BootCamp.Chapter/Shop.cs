using System;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal GetMoney()
        {
            return _money;
        }

        private Inventory _inventory = new();

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
            if (!_inventory.GetItems().Contains(item)) _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            _inventory.SetInventory(_inventory.GetItems().SkipWhile(item => item.GetName() == name).ToArray());
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (item.GetPrice() > _money) return 0;
            Add(item);
            _money -= item.GetPrice();
            return item.GetPrice();
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
        public Item Sell(string itemName)
        {
            var item = Array.Find(_inventory.GetItems(), item => item.GetName() == itemName);
            if (_inventory.GetItems(itemName).Length == 0) return null;
            Remove(itemName);
            _money += item.GetPrice();
            return item;
        }
    }
}