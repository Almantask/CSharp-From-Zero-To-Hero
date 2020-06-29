using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class ShopInventory : Inventory
    {
        private const int _sizeOfInventory = 50;
        public ShopInventory()
        {
            _items = new Item[_sizeOfInventory];
        }

        public void RemoveItem(string name)
        {
            if (_items[0] != null && Array.Exists(_items, x => x.GetName().Equals(name)))
            {
                _items[Array.FindIndex(_items, itemAtIndex => itemAtIndex.GetName().Equals(name))] = null;
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
        }
    }
}
