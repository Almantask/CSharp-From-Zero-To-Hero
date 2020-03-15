using System.Collections.Generic;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; private set; }

        private Inventory _inventory;

        public Shop()
        {
            Money = 0;
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            Money = money;
            _inventory = new Inventory();
        }

        public List<Item> Items { get => _inventory.GetItems(); }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            var items = _inventory.GetItems(item.Name);
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            var itemsToRemove = _inventory.GetItems(name);

            // there should be no duplicates in a shop inventory, so it will return a singleton
            _inventory.RemoveItem(itemsToRemove[0]);
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
            if (price <= Money)
            {
                Money -= price;
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
        public Item Sell(string item)
        {
            var itemList = _inventory.GetItems(item);

            if (itemList.Count == 0)
            {
                return null;
            }

            // itemList should be a singleton since a shop can't contain multiple items of the same name
            var itemToSell = itemList[0];

            Money += itemToSell.Price;
            return itemToSell;
        }
    }
}