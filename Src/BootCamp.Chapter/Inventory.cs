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
        public Item Contains(string name)
        {
            foreach (Item item in Items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        public Item[] GetItems(string name)
        {
            int number = 0;
            int[] placeOfItemsInArr = new int[Items.Count];

            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] != null && Items[i].Name == name)
                {
                    placeOfItemsInArr[number] = i;
                    number++;

                }
            }
            Item[] final = new Item[number];
            for (int i = 0; i < number; i++)
            {
                final[i] = Items[placeOfItemsInArr[i]];
            }

            return final;
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
            for (int i = 0; i < Items.Count; i++)
            {
                if (Items[i] == item)
                {
                    Items.RemoveAt(i);
                    return;
                }
            }
        }
    }
}
