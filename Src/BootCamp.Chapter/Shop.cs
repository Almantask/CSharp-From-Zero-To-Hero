using System.Linq;

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
            _inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            _inventory.RemoveItem(_inventory.GetItems(name).FirstOrDefault());
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            decimal itemPrice = item.GetPrice();

            if(_money >= itemPrice)
            {
                Add(item);
                _money -= itemPrice;
                return itemPrice;
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
            if (_inventory.GetItems().Any(x => x.GetName() == item))
            {
                Item soldItem = _inventory.GetItems(item).FirstOrDefault();
                _inventory.RemoveItem(soldItem);
                _money += soldItem.GetPrice();
                return soldItem;
            }
            else
            {
                return null;
            }
        }
    }
}