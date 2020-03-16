using BootCamp.Chapter.Items;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public List<Item> Items { get; private set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        public List<Item> GetItems(string name)
        {
            var filteredItems = new List<Item>();

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == name)
                {
                    filteredItems.Add(Items[i]);
                }
            }
            return filteredItems;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }
    }
}
