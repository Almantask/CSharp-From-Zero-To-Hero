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
            var foundItems = new Item[0];
            foreach (var item in _items)
            {
                if (item.GetName() == name)
                {
                    foundItems = Add(item);
                }
            }

            return foundItems;
        }

        public void AddItem(Item item)
        {
            _items = Add(item);
        }

        public Item[] Add(Item item)
        {
            var newArray = new Item[_items.Length + 1];
            for (int i = 0; i <= _items.Length - 1; i++)
            {
                newArray[i] = _items[i];
            }
            newArray[^1] = item;
            return newArray;
        }

        public void RemoveByName(string name)
        {
            Item[] newArray = null ;
            if (_items.Length == 0 )
            {
                newArray = _items; 
            }
            else
            {
                newArray = new Item[_items.Length - 1];
            }
            var found = false;
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i].GetName() == name)
                {
                    found = true;
                    continue;
                }

                if (found)
                {
                    newArray[i - 1] = _items[i];
                }
                else
                {
                    newArray[i] = _items[i];
                }
            }

            _items = newArray; 
        }

        
        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            Item[] newArray = null;
            if (_items.Length == 0 )
            {
                newArray = _items;
            }
            else
            {
                newArray = new Item[_items.Length - 1];
            }
           
            var found = false;
            for (int i = 0; i < _items.Length - 1; i++)
            {
                if (_items[i] == item)
                {
                    found = true;
                    continue;
                }

                if (found)
                {
                    newArray[i - 1] = _items[i];
                }
                else
                {
                    newArray[i] = _items[i];
                }
            }

            _items = newArray; 
        }

        
    }
}