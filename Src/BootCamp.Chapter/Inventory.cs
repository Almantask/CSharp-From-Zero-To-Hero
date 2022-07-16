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
            return _items.SkipWhile(item => item.GetName() != name).ToArray();
        }

        public void AddItem(Item item)
        {
            _items = _items.Append(item).ToArray();
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item removedItem)
        {
            _items = _items.SkipWhile(item => item == removedItem).ToArray();
        }

        public void SetInventory(Item[] newItems)
        {
            _items = newItems;
        }
    }
}
