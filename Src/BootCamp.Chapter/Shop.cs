using System;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public Inventory Inventory { get; }
        public decimal Money { get; private set; }

        public Shop(decimal money)
        {
            Inventory = new Inventory();
            Money = money >= 0 ? money : throw new ArgumentException($"{nameof(Money)} cannot be less than 0.");
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            if (item is null) throw new ArgumentNullException($"{nameof(item)} cannot be null.");

            if (Inventory.Items.Contains(item)) return;

            Inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException($"{nameof(name)} cannot be null or empty.");

            Item itemToRemove = Inventory.GetItem(name);

            if (itemToRemove is null) return;
            Inventory.RemoveItem(itemToRemove);
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            var itemPrice = item?.Price ?? throw new ArgumentNullException($"{nameof(item)} cannot be null.");
            if (Money < itemPrice) return 0m;

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
            Item itemToSell = Inventory.GetItem(item);

            if (Inventory.Items.Contains(itemToSell))
            {
                Money += itemToSell.Price;
                return itemToSell;
            }

            return null;
        }
    }
}