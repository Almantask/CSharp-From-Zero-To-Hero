using System;
using System.Linq;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; } = 0;

        private Inventory inventory;
        public Item[] Items { get; set; }

        public Shop(decimal money)
        {
            inventory = new Inventory();
            Items = inventory.Items;
            Money = money;
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            inventory.AddItem(item ?? throw new ArgumentNullException());
            Items = inventory.Items;
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException();
            }
            inventory.RemoveItem(inventory.GetItems(name).FirstOrDefault());
            Items = inventory.Items;
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            decimal itemPrice = item.Price;

            if (Money >= itemPrice)
            {
                Add(item);
                Money -= itemPrice;
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
            if (string.IsNullOrEmpty(item))
            {
                throw new ArgumentNullException();
            }
            if (inventory.Items.Any(x => x.Name == item))
            {
                Item soldItem = inventory.GetItems(item).FirstOrDefault();
                inventory.RemoveItem(soldItem);
                Items = inventory.Items;
                Money += soldItem.Price;
                return soldItem;
            }
            else
            {
                return null;
            }
        }

        public override string ToString()
        {
            return string.Format($"Shop has {Money} money and the following inventory: {base.ToString()}{Environment.NewLine}");
        }
    }
}