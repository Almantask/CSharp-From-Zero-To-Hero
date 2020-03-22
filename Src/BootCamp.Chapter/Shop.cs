using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; }
        public Inventory _inventory;
        public List<Item> Items
        {
            get => _inventory.Items;
        }

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            Money = money;
            _inventory = new Inventory();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(); 
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
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            _inventory.RemoveByName(name);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            var price = item.Price;

            if (price > Money)
            {
                return 0;
            }

            Money -= price;
            return price;
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
            if (String.IsNullOrEmpty(item))
            {
                throw new ArgumentException(); 
            }
                for (int i = 0; i < _inventory.Items.Count; i++)
            {
                if (item == _inventory.Items[i].Name)
                {
                    Money += _inventory.Items[i].Price;
                    return _inventory.Items[i];
                }
            }
            return null;
        }
    }
}