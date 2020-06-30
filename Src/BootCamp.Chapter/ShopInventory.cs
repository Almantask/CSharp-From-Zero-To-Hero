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
            Items = new Item[_sizeOfInventory];
        }

        public void RemoveItem(string name)
        {
            if (Items[0] != null && Array.Exists(Items, x => x.Name.Equals(name)))
            {
                Items[Array.FindIndex(Items, itemAtIndex => itemAtIndex.Name.Equals(name))] = null;
                Console.WriteLine($"{name} has been removed from the inventory.");
            }
        }
    }
}
