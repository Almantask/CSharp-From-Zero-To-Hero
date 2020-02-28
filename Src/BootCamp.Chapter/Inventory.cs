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
            var numberOfMatchName = GetNumberOfMatchName(name);
            if (numberOfMatchName == 0)
            {
                return new Item[0];
            }

            var tempItems = new Item[numberOfMatchName];
            var i = 0;

            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    tempItems[i++] = item;
                }
            }

            return tempItems;
        }

        private int GetNumberOfMatchName(string name)
        {
            var matchName = 0;

            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    matchName++;
                }
            }

            return matchName;
        }

        public void AddItem(Item item)
        {
            var tempItems = new Item[_items.Length + 1];

            for (var i = 0; i < _items.Length; i++)
            {
                tempItems[i] = _items[i];
            }

            tempItems[_items.Length] = item;
            _items = tempItems;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            RemoveItem(item.GetName());
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(string name)
        {
            int removeNumber = GetRemoveNumber(name);

            if (removeNumber > 0)
            {
                var tempItems = new Item[_items.Length - removeNumber];
                var i = 0;

                foreach (var item in _items)
                {
                    if (item.GetName() != name)
                    {
                        tempItems[i++] = item;
                    }
                }

                _items = tempItems;
            }
        }

        private int GetRemoveNumber(string name)
        {
            var removeNumber = 0;

            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    removeNumber++;
                }
            }

            return removeNumber;
        }
    }
}
