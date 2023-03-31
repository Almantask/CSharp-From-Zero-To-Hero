using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; }

        public List<Item> Items => _inventory.Items;
        private readonly Inventory _inventory = new Inventory();

        public Shop(decimal money)
        {
            Money = money;
        }

        public List<Item> GetItems()
        {
            return _inventory.Items;
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            var existingItems = _inventory.GetItems(item.Name);
            if (existingItems.Count > 0)
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

            if (items.Count == 0)
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

            var itemPrice = item.Price;

            if (itemPrice > Money)
            {
                return 0;
            }
            
            Money -= itemPrice;
            
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
            if (items.Count == 0)
            {
                return null;
            }

            Money += items[0].Price;
            
            return items[0];
        }
    }
}