using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; private set; }

        private Inventory _inventory;


        public Shop(decimal money)
        {
            Money = money;
            _inventory = new Inventory();
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
            Item item1 = _inventory.GetItem(item?.Name);
            bool isSameItem = item1?.IsTheSameItem(item) ?? false;

            if (!isSameItem)
            {
                _inventory.AddItem(item);
            }
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            NullChecks.StringNullChecks(name);

            _inventory.RemoveItem(_inventory.GetItem(name));
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            decimal price = item?.Price ?? throw new ArgumentNullException($"{nameof(item)} can't be null.");

            if (price <= Money)
            {
                Money -= price;
                Add(item);
                return price;
            }
            return 0;
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
        public Item Sell(string name)
        {
            NullChecks.StringNullChecks(name);

            Item item1 = _inventory.GetItem(name);

            Money += item1?.Price ?? 0;
            return item1;
        }
    }
}