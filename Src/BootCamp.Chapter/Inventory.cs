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
            return FindItemByName(name);
        }

        public void AddItem(Item item)
        {
            // if (IsItemInInventory(item.GetName())) return;
            var oldItems = CloneItems(1);
            oldItems[^1] = item;
            _items = oldItems;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (IsNullOrEmpty(_items) || !IsItemInInventory(item.GetName())) return;

            var updatedItems = new Item[_items.Length - 1];
            var wasItemFound = false;
            for (var i = 0; i < _items.Length; i++)
            {
                if (!wasItemFound && _items[i].GetName().Equals(item.GetName()))
                {
                    wasItemFound = true;
                    continue;
                }
                var index = (wasItemFound) ? i - 1 : i;
                updatedItems[index] = _items[i];
            }

            _items = updatedItems;
        }

        private Item[] FindItemByName(string name)
        {
            if (IsNullOrEmpty(_items)) return new Item[0];
            foreach (var items in _items)
            {
                if (items.GetName().Equals(name))return new Item[] {items};
            }
            return new Item[0];
        }
        
        private bool IsItemInInventory(string name)
        {
            return FindItemByName(name).Length != 0;
        }
        
        private Item[] CloneItems(int addIndex)
        {
            var newItemList = new Item[_items.Length + addIndex];
            for (var i = 0; i < _items.Length; i++)
            {
                newItemList[i] = _items[i];
            }

            return newItemList;
        }

        private bool IsNullOrEmpty(Item[] items)
        {
            return items == null || items.Length == 0;
        }
    }
}
