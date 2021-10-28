using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private List<Item> _items;
        
        public Item[] GetItems()
        {
            var itemArray = _items.ToArray();
            return itemArray;
        }

        public Inventory()
        {
            _items = new List<Item>();
        }

        public Item[] GetItems(string name)
        {
            //var indexToReturn = 0;
            //for (int i = 0; i < _items.Count; i++)
            //{
            //    var currentName = (_items[i].GetName());
            //    if (currentName == name)
            //    {
            //        indexToReturn = i;
            //    }
            //}

            //Item[] array = _items[0].ToArray();

            return _items.ToArray();
            //return new Item[indexToReturn];
            //return new Item[0];
        }

        public void AddItem(Item item)
        {
            bool existInInventory = false;

            foreach (var tmpItem in _items)
            {
                if (item == tmpItem) existInInventory = true;
            }

            if (!existInInventory)
            {
                _items.Add(item);
            }
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
