namespace BootCamp.Chapter
{
    public class Inventory
    {
        public Item[] _items;
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
            Item[] items = new Item[0];
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].GetName().Equals(name))
                {
                    items = AddItemTo(items, _items[i]);
                }
            }
            return items;
        }

        public void AddItem(Item item)
        {
            _items = AddItemTo(_items, item);
        }

        public Item[] AddItemTo(Item[] items, Item item)
        {
            var copyOfInventory = new Item[items.Length];
            items.CopyTo(copyOfInventory, 0);
            items = new Item[items.Length + 1];

            for (int i = 0; i < copyOfInventory.Length; i++)
            {
                items[i] = copyOfInventory[i];
            }
            items[^1] = item;
            return items;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (!Contains(item))
            {
                return;
            }
            var keepInScope = false;
            var amendedArray = new Item[_items.Length - 1];

            for (int i = 0; i < _items.Length - 1; i++)
            {
                // Once same item will be found
                // It will iterate only in this scope
                if (AreTheSame(_items[i], item) || keepInScope)
                {
                    keepInScope = true;
                    amendedArray[i] = _items[i + 1];
                    continue;
                }
                amendedArray[i] = _items[i];
            }
            _items = amendedArray;
        }

        public bool Contains(Item item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if(AreTheSame(_items[i], item))
                {
                    return true;
                }
            }
            return false;
        }

        public bool AreTheSame(Item item1, Item item2)
        {
            var isNameEqual = item1.GetName().Equals(item2.GetName());
            var isPriceEqual = item1.GetPrice().Equals(item2.GetPrice());
            return isNameEqual && isPriceEqual;
        }
    }
}
