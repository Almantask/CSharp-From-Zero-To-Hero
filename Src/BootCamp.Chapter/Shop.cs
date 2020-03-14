namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; private set; }

        private Inventory _inventory;


        public Shop(decimal money)
        {
            Money = money;
            _inventory = new Inventory();
        }

        public Item[] GetItems()
        {
            return _inventory.Items.ToArray();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if (_inventory.Contains(item.Name) != item)
            {
                _inventory.AddItem(item);
            }
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            _inventory.RemoveItem(_inventory.Contains(name));
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            decimal price = item.Price;

            if (price <= Money)
            {
                Money -= price;
                Add(item);
                return price;
            }
            return 0;
        }

        /// <summary>
        /// Sell item from a shop.
        /// Shop increases it's money.
        /// No money is increased if item does not exist.
        /// </summary>
        /// <returns>
        /// Item sold.
        /// Null, if no item is sold.
        /// </returns>
        public Item Sell(string item)
        {

            Item item1 = _inventory.Contains(item);

            if (item1 != null)
            {
                Money += item1.Price;
                return item1;
            }

            return null;
        }
    }
}