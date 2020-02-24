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
            Item[] wantedItems = new Item[0];
            for (int i = 0; i < _items.Length; i++)
            {
                Item currentItem = _items[i];
                if (currentItem.GetName() == name)
                {
                    wantedItems = Item.Append(wantedItems, currentItem);
                }
            }
            return wantedItems;
        }

        public void AddItem(Item item)
        {
            _items = Item.Append(_items, item);
        }
        public bool ItemExists(Item item)
        {
            return Item.ItemInArray(_items, item);
        }
        public bool ItemExists(string name)
        {
            return Item.NameInArray(_items, name);
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            _items = Item.RemoveItem(_items, item);
        }
        public void RemoveItem(string name)
        {
            _items = Item.RemoveName(_items, name);
        }
    }
}
