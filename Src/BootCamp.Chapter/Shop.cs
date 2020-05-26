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

        public Inventory GetInventory()
        {
            return _inventory;
        }

        public Shop()
        {
            _money = 10000;
            _inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            _money = money;
            _inventory = new Inventory();
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
            if (item == null) return;
            if (_inventory.CheckItemExists(item)) return;

            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            if (string.IsNullOrEmpty(name)) return;
            _inventory.RemoveItem(_inventory.GetFirstItem(name));
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (item == null) return 0;
            
            if (_money < item.GetPrice()) return 0;

            _money -= item.GetPrice();
            _inventory.AddItem(item);
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
            if (item == null) return null;
            Item itemToSell = _inventory.GetFirstItem(item);
            if (itemToSell == null) return null;

            _money += itemToSell.GetPrice();
            _inventory.RemoveItem(itemToSell);
            return itemToSell;
        }
    }
}