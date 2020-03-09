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
            if (_inventory.Contains(item.GetName()) != item)
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
            decimal price = item.GetPrice();

            if (price <= _money)
            {
                _money -= price;
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
            //TODO Sell- adds money to the shop. Shop can only sell items that it has. 
            //Selling item doesn't reduce item count in shop. Returns item sold.

            Item item1 = _inventory.Contains(item);

            if (item1 != null)
            {
                _money += item1.GetPrice();
                return item1;
            }
            
            return null;
        }
    }
}