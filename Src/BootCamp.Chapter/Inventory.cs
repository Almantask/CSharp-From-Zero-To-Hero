using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private List<Item> _items;
        public List<Item> Items => _items;


        public Inventory()
        {
            _items = new List<Item>();
        }

        public List<Item> GetItems(string name)
        {
            var list = new List<Item>();
            foreach (Item item1 in _items)
            {
                if (item1.Name == name)
                    list.Add(item1);
            }
            return list;
        }

        public void AddItem(Item item)
        {
            foreach (Item item2 in _items)
            {
                if (Item.Equals(item2, item))
                    return;
            }
            _items.Add(item);
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (_items.Count == 0)
                return;
            foreach (Item i in _items)
            {
                if (Item.Equals(i, item))
                    _items.Remove(i);
                if (_items.Count == 0)
                    return;
            }
        }
    }
}
