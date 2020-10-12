using System;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private Inventory _inventory;

        public decimal Money { get; set; }

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _inventory = new Inventory();
            Money = money;
        }

        public Item[] GetItems()
        {
            return _inventory.Items;
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            _inventory.RemoveItem(_inventory.GetItems(name).FirstOrDefault());
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            decimal itemPrice = item.Price;

            if (Money >= itemPrice)
            {
                Add(item);
                Money -= itemPrice;
                return itemPrice;
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
            if (_inventory.Items.Any(x => x.Name == item))
            {
                Item soldItem = _inventory.GetItems(item).FirstOrDefault();
                _inventory.RemoveItem(soldItem);
                Money += soldItem.Price;
                return soldItem;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return string.Format($"Shop has {Money} money and the following inventory: {_inventory}{Environment.NewLine}");
        }
    }
}