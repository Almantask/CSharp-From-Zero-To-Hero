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
           if(name is string)
           {
                var list = new List<Item>();
                foreach (Item item1 in _items)
                {
                    if (item1.Name == name)
                        list.Add(item1);
                }
                return list;
           }
           else
           {
                throw new ArgumentException();
           }
            
        }

        public void AddItem(Item item)
        {
            foreach (Item item2 in _items)
            {
                if (item2.Equals(item))
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
                if (i.Equals(item))
                    _items.Remove(i);
                if (_items.Count == 0)
                    return;
            }
        }
    }
}
