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

        private Inventory _inventory;

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _money = money;
            _inventory = new Inventory();
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
            for (int i = 0; i < itemsToRemove.Length; i++)
            {
                if(_inventory.Contains(itemsToRemove[i]))
                {
                    _inventory.RemoveItem(itemsToRemove[i]);
                }
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
            if(_money - item.GetPrice() < 0)
            {
                return 0;
            }
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
        public Item Sell(string item)
        {            
            if (IsItemInShop(item))
            {
                var itemForSale = _inventory.GetItems(item)[0];
                Remove(item);
                _money += itemForSale.GetPrice();
                return itemForSale;
            }

            return null;
        }

        public bool IsItemInShop(string item)
        {            
            try
            {
                var itemForSale = _inventory.GetItems(item)[0];
                if (_inventory.Contains(itemForSale))
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}