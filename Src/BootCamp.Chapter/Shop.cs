using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; }

        public Inventory Inventory { get; set; }
        public List<Item> Items
        {
            get { return Inventory.Items; }
        }

        public Shop()
        {
            Money = 0;
            Inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            Money = money;
            Inventory = new Inventory();
        }


        public void Add(Item item)
        {
            if (Inventory.DoesItemExistInInventory(item.Name))
            {
                return;
            }

            Inventory.AddItem(item);
        }

        public void Remove(string name)
        {
            if (Inventory[name].Count == 0) return;

            var itemToRemove = Inventory[name][0];
            Inventory.RemoveItem(itemToRemove);
        }

        public decimal Buy(Item item)
        {
            if (item.Price > Money)
            {
                return 0;
            }

            Inventory.AddItem(item);
            Money -= item.Price;
            return item.Price;
        }

        public Item Sell(string itemName)
        {
            if (Inventory[itemName].Count == 0)
            {
                return null;
            }

            var itemToSell = Inventory[itemName][0];
            Money += itemToSell.Price;

            return itemToSell;
        }
    }
}
