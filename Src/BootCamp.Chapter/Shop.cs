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
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            foreach(Item item in _inventory.GetItems())
            {
                if (item.GetName() == name)
                    _inventory.RemoveItem(item);
            }
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            bool isBuyOk = _money >= item.GetPrice();
            if (isBuyOk)
            {
                _inventory.AddItem(item);
                _money -= item.GetPrice();
            }
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
            foreach( Item item1 in _inventory.GetItems())
            {
                if(item1.ToString() == item)
                {
                    _inventory.RemoveItem(item1);
                    _money += item1.GetPrice();
                    return item1;
                }                     
            }
            return null;
        }
    }
}