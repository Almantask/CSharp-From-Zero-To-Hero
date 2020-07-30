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
            _money = 0;
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

        public void Add(Item item)
        {
            if (_inventory.DoesItemExistInInventory(item.GetName()))
            {
                return;
            }

            _inventory.AddItem(item);
        }

        public void Remove(string name)
        {
            if (_inventory.GetItems(name).Length == 0) return;

            var itemToRemove = _inventory.GetItems(name)[0];
            _inventory.RemoveItem(itemToRemove);
        }

        public decimal Buy(Item item)
        {
            if (item.GetPrice() > _money)
            {
                return 0;
            }

            _inventory.AddItem(item);
            _money -= item.GetPrice();
            return item.GetPrice();
        }

        public Item Sell(string item)
        {
            if (_inventory.GetItems(item).Length == 0)
            {
                return null;
            }

            var itemToSell = _inventory.GetItems(item)[0];
            _money += itemToSell.GetPrice();

            return itemToSell;
        }
    }
}
