using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal Money => _money;

        private Inventory _inventory;

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _inventory = new Inventory();
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
            bool isRemove = IsRemoveItemByName(name, out _);
            if (!isRemove)
            {
                throw new ArgumentNullException();
            }              
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            bool isBuyOk = _money >= (item?.Price??0);
            if (isBuyOk)
            {
                _inventory.AddItem(item);
                _money -= item.Price;
                return item.Price;
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
            if (IsRemoveItemByName(item,out Item removeItem))
            {
                if (removeItem != null)
                {
                    _money += removeItem.Price;
                    return removeItem;
                }
                else
                    return null;
            }
            else
                throw new ArgumentException();            
        }
        public bool IsRemoveItemByName(string name,out Item removeItem)
        {
            removeItem = null;
            if (String.IsNullOrEmpty(name))
                return false;
            if (_inventory.Items == null)
                return true;
            else
            {
                foreach (var item1 in _inventory.Items)
                {
                    if (item1.Name == name)
                    {
                        _inventory.RemoveItem(item1);
                        removeItem = item1;
                        return true;
                    }
                }
                return true;
            }
        }
    }
}