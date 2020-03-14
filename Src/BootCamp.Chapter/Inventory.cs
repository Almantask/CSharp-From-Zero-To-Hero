using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private List<Item> _items;
        public List<Item> Items
        {
            get => _items;
        }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public List<Item> GetItems(string name)
        {
            var tempItems = new List<Item>();

            foreach (var item in _items)
            {
                if (item.Name == name)
                {
                    tempItems.Add(item);
                }
            }

            return tempItems;
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            _items.Remove(item);
        }

        /// <summary>
        /// Removes item matching criteria by name.
        /// Does nothing if no such name exists
        /// </summary>
        public void RemoveItem(string name)
        {
            for(var i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == name)
                {
                    _items.RemoveAt(i);
                }
            }
        }
    }
}
