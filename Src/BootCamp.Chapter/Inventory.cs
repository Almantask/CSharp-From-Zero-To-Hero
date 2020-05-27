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
            Item[] allItems = GetItems();
            Item[] filteredItems = new Item[1];

            if (allItems[0] == null) return filteredItems;

            foreach (Item Item in allItems)
            {
                if (Item.GetName() == name)
                {
                    if (allItems.Length > 1)
                    {
                        var temp = (Item[]) filteredItems.Clone();
                        filteredItems = new Item[filteredItems.Length + 1];
                        temp.CopyTo(filteredItems, 0);
                    }
                    filteredItems[^1] = Item;
                }
            }
            return filteredItems;
        }

        public Item GetFirstItem(string name)
        {
            foreach (Item item in _items)
            {
                if (item.GetName() == name) return item;
            }

            return null;
        }

        public void AddItem(Item item)
        {
            if (item == null) return;
            if (GetItems().Length == 1)
            {
                _items[0] = item;
                return;
            }
            
            Array.Resize(ref _items, _items.Length + 1);
            _items[^1] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (item == null) return;

            var allItems = GetItems();

            for (int i = 0; i < allItems.Length; i++)
            {
                if (allItems[i] == item)
                {
                    DeleteIndexShiftElements(allItems, i);
                }
            }
        }

        private void DeleteIndexShiftElements(Item[] array, int index)
        {
            if (array.Length == 1)
            {
                array[0] = null;
                return;
            }

            Object[] temp = new Object[array.Length - 1];
            Array.ConstrainedCopy(array, 0, temp, 0, array.Length-1);

            for (int i = index; i < array.Length; i++)
            {
                temp[i] = array[i + 1];
            }

            
        }
        public bool CheckItemExists(Item item)
        {
            foreach (Item candidate in _items)
            {
                if (item == candidate)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
