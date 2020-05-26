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

            Items.Add(item);
            RemainingSpace--;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (Items.Contains(item))
            {
                Items.Remove(item);
                RemainingSpace++;
            }
        }
    }
}