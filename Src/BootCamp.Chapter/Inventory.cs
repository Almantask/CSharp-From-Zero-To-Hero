using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            //Items = new List<Item>(); 
        }

        public List<Item> GetItems(string name)
        {
            var foundItems = new List<Item>();
            foreach (var item in Items)
            {
                if (item.Name == name)
                {
                    foundItems.Add(item);
                }
            }

            return foundItems;
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

        public void RemoveByName(string name)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == name)
                {
                    Items.Remove(Items[i]);
                }
            }
        }
    }
}