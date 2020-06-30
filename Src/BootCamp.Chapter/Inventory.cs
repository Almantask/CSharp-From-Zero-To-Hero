using System.Runtime.ExceptionServices;
using System;
using System.Reflection.Metadata.Ecma335;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        protected Item[] _items;

        public Item[] Items{get{ return _items; } }

        // displays all items in inventory
        // renamed from 'GetItems' to show the clear different from the 'GetItems' method below
        public void ShowAllItems()
        {
            if (!Array.TrueForAll(_items, IsNull => IsNull == null))
            {
                Console.WriteLine("Items in inventory:\n");
                foreach (var item in _items)
                {
                    if (item != null)
                    {
                        Console.WriteLine(item.Name);
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            else
            {
                Console.WriteLine("The inventory is currently empty.");
            }
        }

        public Item GetItem(string name)
        {
            return _items[Array.FindIndex(_items, element => element.Name.Equals(name))];         
        }

        // adding an item to the array at the next available slot
        public void AddItem(Item item)
        {
            for(int i = 0; i < _items.Length; i++)
            {
                if(_items[i] == null)
                {
                    _items[i] = item;
                    Console.WriteLine($"{item.Name} has been added");
                    return;
                }
            }
            throw new InventoryIsFullException("The inventory is currently full! You will need to sell an item to create room!");
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if(_items[0] != null && Array.Exists(_items, x => x.Equals(item)))
            {
                _items[Array.FindIndex(_items, itemAtIndex => itemAtIndex == item)] = null;
                Console.WriteLine($"{item.Name} has been removed from the inventory.");
            }
        }
    }
}
