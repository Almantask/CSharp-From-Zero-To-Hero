using System;
using System.Linq.Expressions;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        private ShopInventory _inventory;

        public Shop(decimal money)
        {
            _money = money;
            _inventory = new ShopInventory();
        }

        public decimal GetMoney()
        {
            return _money;
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
            try
            {
                _inventory.AddItem(item);
            }
            catch (InventoryIsFullException msg)
            {
                Console.WriteLine(msg);
            }
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            _inventory.RemoveItem(name);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (GetMoney() >= item.GetPrice())
            {
                Add(item);
                _money -= item.GetPrice();
                Console.WriteLine($"{item.GetName()} was sold to the Shop!");
                return item.GetPrice();
            }
            else
            {
                Console.WriteLine("The Shop cannot afford to buy that item!");
                return 0;
            }
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
            if (Array.Exists(_inventory.GetItems(), element => element.GetName().Equals(item)))
            {
                _money += _inventory.GetItem(item).GetPrice();
                var itemSold = _inventory.GetItem(item);
                _inventory.RemoveItem(_inventory.GetItem(item));
                Console.WriteLine("Item is sold!");
                return itemSold;
            }
            else
            {
                Console.WriteLine("That item was not in the Shop!");
                return null;
            }
        }
    }
}