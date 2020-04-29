using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public List<Item> Items { get; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        // I dont know how to make a getter property with arguments or even if it is possible.
        public List<Item> GetItems(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return FindItemByName(name);
        }

        public void AddItem(Item item)
        {
            Items.Add(item ?? throw new ArgumentNullException(nameof(item)));
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item ?? throw new ArgumentNullException(nameof(item)));
        }

        private List<Item> FindItemByName(string name)
        {
            var foundItems = new List<Item>();
            foreach (var item in Items)
            {
                if (item.Name.Equals(name)) foundItems.Add(item);
            }
            
            return foundItems;
        }
    }
}
