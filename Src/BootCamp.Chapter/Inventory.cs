using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private List<Item> _items;
        public List<Item> Items { get { return new List<Item>(_items); } private set { _items = value; } }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public List<Item> GetItems(string name)
        {
            var filteredItems = new List<Item>();

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == name)
                {
                    filteredItems.Add(_items[i]);
                }
            }
            return filteredItems;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }
    }
}
