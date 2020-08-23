using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems()
        {
            return _items;
        }


        public Item[] GetItems(string name)
        {
            List<Item> itemList = new List<Item>();
            for (int i = 0; i < GetItems().Length; i++)
            {
                if (_items[i].GetName() == name)
                {
                    itemList.Add(_items[i]);
                }
            }

            return itemList.ToArray();
        }

        public void AddItem(Item item)
        {
            if (CheckIfITemExists(item) == false)
            {
                Item[] newItemArray = new Item[GetItems().Length + 1];
                for (int i = 0; i < GetItems().Length; i++)
                {
                    newItemArray[i] = _items[i];
                }
                newItemArray[newItemArray.Length - 1] = item;

                _items = newItemArray;
            }
        }

        /// <summary>
        /// Removes item matching critieria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (CheckIfITemExists(item) == true)
            {
                Item[] removeItemArray = new Item[GetItems().Length - 1];
                for (int i = 0; i < GetItems().Length; i++)
                {
                    if (_items[i] != item)
                    {
                        removeItemArray[i] = _items[i];
                    }
                }
                _items = removeItemArray;
            }
        }

        public bool CheckIfITemExists(Item item)
        {
            bool doesItemExists = false;

            for (int i = 0; i < GetItems().Length; i++)
            {
                if (_items[i] == item)
                {
                    return doesItemExists = true;
                }
            }
            return doesItemExists;
        }
    }
}
