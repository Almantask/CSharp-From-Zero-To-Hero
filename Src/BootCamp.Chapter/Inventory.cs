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
            var tempItems = new List<Item>();

            foreach (var item in Items)
            {
                if (item.Name == name)
                {
                    tempItems.Add(item);
                }
            }

            return tempItems;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        /// <summary>
        /// Removes item matching criteria by name.
        /// Does nothing if no such name exists
        /// </summary>
        public void RemoveItem(string name)
        {
            for(var i = 0; i < Items.Count; i++)
            {
                if (Items[i].Name == name)
                {
                    Items.RemoveAt(i);
                }
            }
        }
    }
}
