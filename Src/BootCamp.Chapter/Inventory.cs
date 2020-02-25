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
            var foundItems = new Item[1]; 
            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    foundItems[0] = item; 
                }

            }

            return foundItems; 
        }

        public void AddItem(Item item)
        {
            _items = AppendToArray(item); 
        }

        private Item[] AppendToArray(Item item)
        {
            var newItemArray = new Item[_items.Length + 1];
            for (int i = 0; i < _items.Length - 1; i++)
            {
                newItemArray[i] = _items[i];
            }
            newItemArray[^1] = item;
            return newItemArray; 
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            _items = RemoveFromArray(item);
            
        }

        private Item[] RemoveFromArray(Item item)
        {
            if (_items.Length == 0)
            {
                return _items; 
            } 

            var newItemArray = new Item[_items.Length - 1];
            var indexItem = Array.IndexOf(_items, item); 
            for (int i = 0; i < _items.Length - 1; i++)
            {
                if (i < indexItem)
                {
                    
                    newItemArray[i] = _items[i];
                }
                else if (i > indexItem)
                {
                   
                    newItemArray[i - 1] = _items[i];
                }

            }
           
            return newItemArray;
        }
    }
}
