#nullable enable
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; }

        public Inventory Inventory { get; set; }

        public Shop(decimal money)
        {
            Money = money;
            Inventory = new Inventory();
        }


        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            Item recievedItem = item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null.");

            if (Inventory.GetItems(item.Name).Contains(item)) return;

            Inventory.AddItem(item);
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            Inventory.RemoveItem(Inventory.GetFirstItem(name ?? throw new ArgumentNullException(nameof(name) + " shouldn't be null.")));
        }

        /// <summary>
        /// Player can sell Inventory to a shop.
        /// All Inventory can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            Item recievedItem = item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null.");

            if (Money < item.Price) return 0;

            Money -= item.Price;
            Inventory.AddItem(item);
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
            if(item == "") throw new ArgumentException(nameof(item)+ " shouldn't be empty.");
            Item itemToSell =
                Inventory.GetFirstItem(item ?? throw new ArgumentNullException(nameof(item) + " shouldn't be null."));
            if (itemToSell is null) return null;

            Money += itemToSell.Price;
            Inventory.RemoveItem(itemToSell);
            return itemToSell;
        }
    }
}