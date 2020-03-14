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
            var numberOfMatchName = GetMatchingNamesCount(name);
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

        private int GetMatchingNamesCount(string name)
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

        public void RemoveItem(Item item)
        {
            RemoveItem(item.GetName());
        }

        /// <summary>
        /// Removes item matching criteria by name.
        /// Does nothing if no such name exists
        /// </summary>
        public void RemoveItem(string name)
        {
            int removeNumber = GetRemoveCount(name);

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

        private int GetRemoveCount(string name)
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
