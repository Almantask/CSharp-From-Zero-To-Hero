using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        public List<Item> GetItems(string name)
        {
            string Name = name ?? throw new ArgumentNullException(nameof(name) + " shouldn't be null.");
            return Items.Where(n => n.Name == name).ToList();
        }

        public Item GetFirstItem(string name)
        {
            string Name = name ?? throw new ArgumentNullException(nameof(name) + " shouldn't be null.");
            foreach (Item item in Items)
            {
                if (item.Name == name) return item;
            }

            return null;
        }

        public void AddItem(Item item)
        {
            Items.Add(item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null."));
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            Items.Remove(item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null."));
        }
    }
}