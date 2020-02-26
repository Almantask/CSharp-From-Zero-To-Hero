namespace BootCamp.Chapter
{
    public class Inventory
    {
        private int itemIdx = 0;
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
            _items[++itemIdx] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            foreach (var merchandise in _items)
            {
                if (merchandise.GetName() = item.GetName)
                {
                    foreach (var item in collection)
                    {

                    }
                }
            }
        }
    }
}
