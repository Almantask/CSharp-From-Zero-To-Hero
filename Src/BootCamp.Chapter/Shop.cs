using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; private set; }
        private Inventory _inventory;
        
        public List<Item> Items => _inventory.Items;

        public Shop(decimal money)
        {
            Money = money;
            _inventory = new Inventory();
        }

        public void Add(Item item)
        {
            if(item == null) return;
            _inventory.AddItem(item);
        }

        public void Remove(string name)
        {
            var item = _inventory.GetItems(name);
            if (item == null) return;
            
            _inventory.RemoveItem(item[0]);
        }
        
        public decimal Buy(Item item)
        {
            var itemPrice = item.Price;
            if (Money < itemPrice) return 0m;
            Money -= itemPrice;
            return itemPrice;
        }

        public Item Sell(string item)
        {
            if (item == null) return null;
            var itemToSell = _inventory.GetItems(item);
            if (itemToSell == null) return null;
            
            _inventory.RemoveItem(itemToSell[0]);
            Money += itemToSell[0].Price;
            
            return itemToSell[0];
        }
    }
}