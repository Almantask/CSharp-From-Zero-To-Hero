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
            Item[] filteredItems = new Item[0];

            foreach (Item Item in allItems)
            {
                if (Item.GetName() == name)
                {
                    if (filteredItems.Length > 0)
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

        public void AddItem(Item item)
        {
            if (item == null) return;

            Item[] temp = GetItems();
            _items = new Item[temp.Length + 1];
            temp.CopyTo(_items, 0);
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

        private void DeleteIndexShiftElements(Object[] array, int index)
        {
            if (array == null || index == null) return;
            if ((array.Length - index + 1) < 0) throw new InvalidOperationException("Wrong index or array!");
            if (array.Length == 1)
            {
                array[0] = null;
                return;
            }

            Object[] temp = new object[array.Length - 1];
            Array.ConstrainedCopy(array, 0, temp, 0, array.Length-1);

            for (int i = index; i < array.Length; i++)
            {
                temp[i] = array[i + 1];
            }

            array = new object[array.Length -1];
            array = temp;
        }
    }
}
