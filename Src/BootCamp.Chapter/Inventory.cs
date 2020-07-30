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

            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    return new Item[1] { item };
                }
            }
            return new Item[0];
        }

        public void AddItem(Item item)
        {
            Item[] newItems = new Item[_items.Length + 1];

            for (int i = 0; i < _items.Length; i++)
            {
                newItems[i] = _items[i];
            }
            newItems[^1] = item;

            _items = newItems;
        }

        public void RemoveItem(Item item)
        {
            if (!DoesItemExistInInventory(item.GetName()))
            {
                return;
            }

            Item[] newItems = new Item[_items.Length - 1];

            bool wasItemFound = false;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == item)
                {
                    wasItemFound = true;
                    continue;
                }

                if (!wasItemFound)
                {
                    newItems[i] = _items[i];
                }
                else
                {
                    newItems[i - 1] = _items[i];
                }

            }
            _items = newItems;
        }

        public bool DoesItemExistInInventory(string name)
        {

            foreach (var existingItem in _items)
            {
                if (existingItem.GetName() == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
