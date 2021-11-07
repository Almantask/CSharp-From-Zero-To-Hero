using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    public class Shop
    {
        private decimal _money;
        public decimal Money
        {
            get => _money;
        }

        private Inventory _inventory;

        public Shop()
        {

        }

        public Shop(decimal money)
        {
            _money = money;
            this._inventory = new Inventory();
        }

        public IItem[] GetItems()
        {
            return _inventory.GetItems();
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(IItem item)
        {
            var itemsInInventory = this._inventory.GetItems();
            bool existInInventory = false;

            foreach (var tmpItem in itemsInInventory)
            {
                if (item == tmpItem) existInInventory = true;
            }

            if (!existInInventory)
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
            var itemsInInventory = _inventory.GetItems();
            for(int i = 0; i < itemsInInventory.Length; i++)
            {
                if (itemsInInventory[i].Name == name)
                {
                    _inventory.RemoveItem(itemsInInventory[i]);
                }
            }
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(IItem item)
        {
            var itemPrice = item.Price;
            decimal priceReturn;

            if (_money >= itemPrice)
            {
                _inventory.AddItem(item);
                _money -= itemPrice;
                priceReturn = itemPrice;
            }
            else
            {
                priceReturn = 0;
            }

            return priceReturn;
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
        public IItem Sell(string item)
        {
            var itemsInInventory = _inventory.GetItems();
            int index = 0;

            for (int i = 0; i < itemsInInventory.Length; i++)
            {
                if (itemsInInventory[i].Name == item) index = i;
            }

            decimal money = itemsInInventory[index].Price;
            _money += money;

            return itemsInInventory[index];
        }
    }
}