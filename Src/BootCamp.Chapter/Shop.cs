using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal Money
        {
            get => _money;
        }

        private Inventory _inventory;

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money) : this()
        {
            _money = money;
        }

        public List<Item> Items
        {
            get => _inventory.Items;
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
            if (_money - item.Price < 0)
            {
                return 0;
            }
            _money -= item.Price;
            return item.Price;
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
            foreach (var merchandise in _inventory.Items)
            {
                if (merchandise.Name == item)
                {
                    _money += merchandise.Price;
                    return merchandise;
                }
            }
            return null;
        }
    }
}