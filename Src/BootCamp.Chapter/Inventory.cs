namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;

        public Item[] GetItems()
        {
            return _items;
        }

        private int _size;

        public int GetSize()
        {
            return _size;
        }

        private int _remainingSpace;

        public int GetRemainingSpace()
        {
            return _remainingSpace;
        }

        public Inventory(int size)
        {
            _size = size;
            _items = new Item[size];
            _remainingSpace = size;
        }

        public Item[] GetItem(string name)
        {
            return new Item[0];
        }

        public void AddItem(Item item)
        {
            if (GetRemainingSpace() == 0) return;

            for (int i = 0; i < _size; i++)
            {
                if (_items[i] == null)
                {
                    _items[i] = item;
                    _remainingSpace--;
                    break;
                }
            }
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {
            if (InventoryContains(item, out int index))
                _items[index] = null;
        }

        /// <summary>
        /// Checks whether the inventory contains an item and returns true or false. If true, it also returns the index of the item in the inventory.
        /// </summary>
        /// <param name="itemToCheck"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool InventoryContains(Item itemToCheck, out int index)
        {
            index = 0;

            for (int i = 0; i < GetSize(); i++)
            {
                if (_items[i].GetName() == itemToCheck.GetName())
                {
                    index = i;
                    return true;
                }
            }

            return false;
        }
    }
}
