using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public List<Item> Items { get; set; }

        public Inventory()
        {
            Items = new List<Item>();
        }

        /// <summary>
        /// Returns the item it found based on the name you gave, if no item is found returns null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Item GetItem(string name)
        {
            NullChecks.StringNullChecks(name);

            foreach (Item item in Items)
            {
                if (item?.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        /// <summary>
        /// Returns a List of all items that are in the inventory based on the name you gave.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public List<Item> GetItems(string name)
        {
            NullChecks.StringNullChecks(name);

            List<Item> final = new List<Item>();

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i]?.Name == name)
                {
                    final.Add(Items[i]);
                }
            }
            return final;
        }
        /// <summary>
        /// Add an item to the inventory.
        /// </summary>
        /// <param name="item"></param>
        public void AddItem(Item item)
        {
            Items.Add(item ?? throw new ArgumentNullException($"{nameof(item)} can't be null."));
        }

        /// <summary>
        /// Removes ONE item matching criteria by item.
        /// Does nothing if no such item exists.
        /// </summary>
        public void RemoveItem(Item item)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i].IsTheSameItem(item ?? throw new ArgumentNullException($"{nameof(item)} can't be null.")))
                {
                    Items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
