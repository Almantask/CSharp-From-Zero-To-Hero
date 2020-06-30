using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class PlayerInventory : Inventory
    {
        private const int _sizeOfInventory = 15;
        public PlayerInventory()
        {
            Items = new Item[_sizeOfInventory];
        }

        public Item[] GetItems(string name)
        {
            return Items;           
        }
    }

}
