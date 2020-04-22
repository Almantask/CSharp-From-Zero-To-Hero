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
            if(item == null) return;
            var itemName = item.GetName();
            // if (_inventory.GetItems(itemName).Length == 0) return;
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            var item = _inventory.GetItems(name);
            if (item.Length == 0) return;
            
            _inventory.RemoveItem(item[0]);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            var itemPrice = item.GetPrice();
            if (_money < itemPrice) return 0m;
            _money -= itemPrice;
            return itemPrice;
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
            var itemToSell = _inventory.GetItems(item);
            if (itemToSell.Length == 0) return null;
            _inventory.RemoveItem(itemToSell[0]);
            _money += itemToSell[0].GetPrice();
            
            return itemToSell[0];
        }
    }
}