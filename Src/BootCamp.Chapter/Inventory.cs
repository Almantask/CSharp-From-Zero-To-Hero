namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        public Item[] GetItems()
        {
            return new Item[0];
        }

        public Inventory()
        {
            _items = new Item[0];
        }

        public Item[] GetItems(string name)
        {
            return new Item[0];
        }

        public void AddItem(Item item)
        {

        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {

        }
    }
}
