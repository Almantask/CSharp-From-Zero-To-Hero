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
            Item[] searchItem = Array.Empty<Item>();
            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    Array.Resize(ref searchItem, searchItem.Length + 1);
                    searchItem[^1] = item;
                }
            }
            
            return searchItem;
        }

        public void AddItem(Item item)
        {
            int currentInventoryLength = _items.Length;
            Array.Resize(ref _items, currentInventoryLength +1);
            _items[currentInventoryLength] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            int searchItemIndex = Array.IndexOf(_items, item);

            if (searchItemIndex == -1)
            {
                return;
            }
            
            int newArraySize = _items.Length-1;
            Item[] newItemArray = new Item[newArraySize];

            for (int i = 0, j = 0; i < _items.Length; i++)
            {
                if (i != searchItemIndex)
                {
                    newItemArray[j] = _items[i];
                    j++;
                }
            }

            _items = newItemArray;
        }
    }
}
