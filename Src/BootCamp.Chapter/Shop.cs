namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;

        public decimal GetMoney()
        {
            return _money;
        }

        private Inventory _inventory;

        public Shop()
        {
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _inventory = new Inventory();
            _money = money;
        }

        public Item[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if (_inventory.InventoryContains(item, out int index)) return;

            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Item[] itemToRemove = _inventory.GetItem(name);

            _inventory.RemoveItem(itemToRemove[0]);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (GetMoney() < item.GetPrice()) return 0m;

            _inventory.RemoveItem(item);
            _money -= item.GetPrice();
            return item.GetPrice();
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
            Item[] itemToSell = _inventory.GetItem(item);

            if (_inventory.InventoryContains(itemToSell[0], out int index))
            {
                _money += itemToSell[0].GetPrice();
                return itemToSell[0];
            }

            return null;
        }
    }
}