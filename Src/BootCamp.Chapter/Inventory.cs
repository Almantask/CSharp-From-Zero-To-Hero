namespace BootCamp.Chapter
{
    public class Inventory
    {
        private Item[] _items;
        
        public Item[] GetItems()
        {
            return new Item[0];
        }

        public Inventory()
        {
            _items = new Item[Item.totalItemCount];
        }

        public Item[] GetItems(string name)
        {
            var indexToReturn = 0;
            for (int i = 0; i < _items.Length; i++)
            {
                var currentName = (_items[i].GetName());
                if (currentName == name)
                {
                    indexToReturn = i;
                }
            }

            return new Item[indexToReturn];
            //return new Item[0];
        }

        public void AddItem(Item item)
        {
            var tempArr = _items;
            var newArr = new Item[_items.Length + 1];



            _items[0] = item;
        }

        /// <summary>
        /// Removes item matching criteria by item.
        /// Does nothing if no such item exists
        /// </summary>
        public void RemoveItem(Item item)
        {

        }

        
    }
}
