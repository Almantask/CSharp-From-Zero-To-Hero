using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Item[] GetItems()
        {
            return _items;
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems(string name)
        {
            return _items.Where(x => x.GetName() == name).ToArray();
        }

        public void AddItem(Item item)
        {
            if(_items.Any(x => x.GetName() == item.GetName()))
            {
                return;
            }

            var newItemArray = new Item[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                newItemArray[i] = _items[i];
            }

            newItemArray[^1] = item;
            _items = newItemArray;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if(_items.Any(x => x.GetName() == item.GetName()))
            {
                int index = 0;
                var newItemArray = new Item[_items.Length - 1];

                for (int i = 0; i < _items.Length; i++)
                {
                    if (item.GetName() == _items[i].GetName())
                    {
                        continue;
                    }

                    newItemArray[index] = _items[i];
                    index++;
                }

                _items = newItemArray;
            }
        }
        public override string ToString()
        {
            return string.Format($"{InventoryToString()}");
        }

        private string InventoryToString()
        {
            string result = "";

            foreach (var item in _items)
            {
                result += $"{item.GetName()}, ";
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
