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
            int number = 0;
            int[] placeOfItemsInArr = new int[_items.Length];

            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == null)
                { }
                else if (_items[i].GetName() == name)
                {
                    placeOfItemsInArr[number] = i;
                    number++;

                }
            }
            Item[] final = new Item[number];
            for (int i = 0; i < number; i++)
            {
                final[i] = _items[placeOfItemsInArr[i]];
            }

            return final;
        }

        public void AddItem(Item item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == null)
                {
                    _items[i] = item;
                    return;
                }
            }
            _items = new Item[_items.Length + 1];
            _items[_items.Length -1] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            for (int i = 0; i < _items.Length; i++)
            {
                if (_items[i] == item)
                {
                    _items[i] = null;
                    return;
                }
            }
        }
    }
}
