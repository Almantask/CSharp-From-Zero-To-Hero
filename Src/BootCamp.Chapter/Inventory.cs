using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory 
    {
        private List<IItem> _items = new List<IItem>();
        public IItem[] GetItems()
        {
            var itemArray = _items.ToArray();
            return itemArray;
        }

        public Inventory()
        {
            //_items = new List<IItem>();
        }

        public IItem[] GetItems(string name)
        {
            return _items?.ToArray();
        }

        public void AddItem(IItem item)
        {
            _items?.Add(item);
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(IItem item)
        {
            _items?.Remove(item);
        }

        public bool ContainItem(IItem item)
        {
            return _items.Contains(item);
        }
    }
}
