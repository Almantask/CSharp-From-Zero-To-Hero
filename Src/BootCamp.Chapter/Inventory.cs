using System;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;

        public Item[] GetItems()
        {
            return _items;
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems(string name)
        {
            var foundItems = new Item[0];
            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    foundItems = item.AddItem(foundItems,item); 
                }
            }

            return foundItems;
        }

        public void AddItem(Item item)
        {
            _items = item.AddItem(_items, item);
        }

        internal bool SearchItem(string name)
        {
            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    return true; 
                }
            }

            return false; 
        }

        internal void RemoveByName(string name)
        {
            _items = Item.RemoveByBame(_items, name); 
        }



        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            _items = Item.RemoveFromArray(_items, item);
        }

       
    }
}