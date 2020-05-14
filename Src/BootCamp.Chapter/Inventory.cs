using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private const int defaultInventorySize = 10;

        public List<Item> Items { get; private set; }
        public int Size { get; private set; }
        public int RemainingSpace { get; set; }

        public Inventory()
        {
            Size = defaultInventorySize;
            RemainingSpace = defaultInventorySize;
            Items = new List<Item>(defaultInventorySize);
        }

        public Item[] GetItem(string name)
        {
            if (RemainingSpace == Size) return new Item[0];

            foreach (var item in Items)
            {
                if (item.Name == name)
                {
                    return new Item[] { item };
                }
            }

            return new Item[0];
        }

        public void AddItem(Item item)
        {
            if (RemainingSpace == 0) return;

            for (int i = 0; i < Size; i++)
            {
                if (Items[i] == null)
                {
                    Items[i] = item;
                    RemainingSpace--;
                    break;
                }
            }
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (InventoryContains(item, out int index))
            {
                Items[index] = null;
                RemainingSpace++;
            }
        }

        /// <summary>
        /// Checks whether the inventory contains an item and returns true or false. If true, it also returns the index of the item in the inventory.
        /// </summary>
        /// <param name="itemToCheck"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool InventoryContains(Item itemToCheck, out int index)
        {
            index = 0;

            if (RemainingSpace == Size) return false;

            for (int i = 0; i < Size; i++)
            {
                if (Items[i].Name == itemToCheck.Name)
                {
                    index = i;
                    return true;
                }
            }

            return false;
        }
    }
}