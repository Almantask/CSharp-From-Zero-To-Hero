using System.Runtime.ExceptionServices;
using System;
using System.Reflection.Metadata.Ecma335;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public Item[] Items{ get; set; }

        ///<summary>
        /// Displays all items in inventory
        ///</summary>
        public void DisplayInventory()
        {
            _ = Items ?? throw new ArgumentNullException("Inventory is Null/Empty");

            Console.WriteLine("Items in inventory:\n");
            foreach (var item in Items)
            {
                if (item != null)
                {
                    Console.WriteLine(item.Name);
                }
                else
                {
                    continue;
                }
            }
        }

        public Item GetItem(string name)
        {
            return Items[Array.FindIndex(Items, element => element.Name.Equals(name))];         
        }

        // adding an item to the array at the next available slot
        public void AddItem(Item item)
        {
            for(int i = 0; i < Items.Length; i++)
            {
                if(Items[i] == null)
                {
                    Items[i] = item;
                    Console.WriteLine($"{item.Name} has been added");
                    return;
                }
            }
            throw new InventoryIsFullException("The inventory is currently full! You will need to sell an item to create room!");
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if(Items[0] != null && Array.Exists(Items, x => x.Equals(item)))
            {
                Items[Array.FindIndex(Items, itemAtIndex => itemAtIndex == item)] = null;
                Console.WriteLine($"{item.Name} has been removed from the inventory.");
            }
        }
    }
}
