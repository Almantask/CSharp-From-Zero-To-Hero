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

        public List<Item> GetItems(string name)
        {
            return FindItemByName(name);
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
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
