using System.Linq;

namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems()
        {
            return _items;
        }


        public Item[] GetItems(string name)
        {
            foreach(var item in _items)
            {
                if(item.GetName() == name)
                {
                    return new Item[1];
                }
            }
            return new Item[0];
        }

        public void AddItem(Item item)
        {
            Item[] newItem = new Item[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                newItem[i] = _items[i];

            }
            newItem[_items.Length] = item;

            _items = newItem;

        }

        /// <summary>
        /// Removes item matching critieria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            Item[] removeItem = new Item[_items.Length -1];
            removeItem = removeItem.Where(val => val != item).ToArray();
        }
    }
}
