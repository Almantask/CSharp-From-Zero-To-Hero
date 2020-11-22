using System;
using System.Collections;

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
            ArrayList list = new ArrayList();
            foreach (Item item1 in _items)
            {
                if (item1.GetName() == name)
                    list.Add(item1);
            }
            return (Item[])list.ToArray();
        }

        public void AddItem(Item item)                  
        {
            foreach(Item item2 in _items)
            {
                if (item2 == item)
                    return;
                else
                {
                    _items = new Item[_items.Length + 1];
                    _items[_items.Length] = item;
                }
            }
            
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (_items.Length == 0)
                return ;
            for(int i = 0; i < _items.Length; i++)
            {
                if(_items[i] == item)
                {                   
                    var temp = new Item[_items.Length - 1];
                   for(int j = 0; j <_items.Length -1;j++)
                    {
                        if (j < i)
                            temp[j] = _items[j];
                        else
                            temp[j] = _items[j + 1];
                    }
                    _items = new Item[_items.Length - 1];
                    _items = temp;                    
                }
            }
        }
    }
}
















