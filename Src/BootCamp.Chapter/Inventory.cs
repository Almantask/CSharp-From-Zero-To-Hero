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

        public List<Item> this[string name]
        {
            get
            {
                return GetItemsByName(name);
            }
        }

        public List<Item> GetItemsByName(string name)
        {
            var items = new List<Item>();
            foreach (var item in Items)
            {
                if (item.Name == name)
                {
                    items.Add(item);
                }
            }
            return items;
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            Items.Remove(item);
        }

        public bool DoesItemExistInInventory(string name)
        {

            foreach (var existingItem in Items)
            {
                if (existingItem.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
