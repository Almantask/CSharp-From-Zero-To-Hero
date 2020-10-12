using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        public Item[] Items { get; set; }

        public Inventory()
        {
            Items = new Item[0];
        }

        public Item[] GetItems(string name)
        {
            return Items.Where(x => x.Name == name).ToArray();
        }

        public void AddItem(Item item)
        {
            if (Items.Any(x => x.Name == item.Name))
            {
                return;
            }

            var newItemArray = new Item[Items.Length + 1];

            for (int i = 0; i < Items.Length; i++)
            {
                newItemArray[i] = Items[i];
            }

            newItemArray[^1] = item;
            Items = newItemArray;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (Items.Any(x => x.Name == item.Name))
            {
                int index = 0;
                var newItemArray = new Item[Items.Length - 1];

                for (int i = 0; i < Items.Length; i++)
                {
                    if (item.Name == Items[i].Name)
                    {
                        continue;
                    }

                    newItemArray[index] = Items[i];
                    index++;
                }

                Items = newItemArray;
            }
        }

        public override string ToString()
        {
            return string.Format($"{InventoryToString()}");
        }

        private string InventoryToString()
        {
            string result = "";

            foreach (var item in Items)
            {
                result += $"{item.Name}, ";
            }

            if (string.IsNullOrEmpty(result))
            {
                return "";
            }

            result = result.Remove(result.Length - 2);
            return result;
        }
    }
}