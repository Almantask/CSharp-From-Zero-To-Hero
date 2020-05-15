using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public Inventory Inventory { get; private set; }
        public decimal Money { get; private set; }

        public Shop()
        {
            Inventory = new Inventory();
        }

        public Shop(decimal money)
        {
            Inventory = new Inventory();
            Money = money;
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if (Inventory.Items.Contains(item) || item is null) return;

            Inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Item[] itemToRemove = Inventory.GetItem(name);

            if (itemToRemove.Length == 0) return;
            Inventory.RemoveItem(itemToRemove[0]);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            if (Money < item.Price) return 0m;

            Inventory.RemoveItem(item);
            Money -= item.Price;
            return item.Price;
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
            Item[] itemToSell = Inventory.GetItem(item);

            if (Inventory.Items.Contains(itemToSell[0]))
            {
                Money += itemToSell[0].Price;
                return itemToSell[0];
            }

            return null;
        }
    }
}