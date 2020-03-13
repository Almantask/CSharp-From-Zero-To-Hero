using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class Shop
    {
        public decimal Money { get; set; }
        public List<Item> Items { get; set; }

        
        // make a constructor 
        public Shop()
        {
           
            Items = new List<Item>();
        }

        public Shop(decimal money)
        {
            Money = money;
            Items = new List<Item>();
        }

        public List<Item> GetItems()
        {
            return Items; 
        }

        /// <summary>
        /// Adds item to the stock.
        /// If item of same name exists, does nothing.
        /// </summary>
        public void Add(Item item)
        {
            Items.Add(item); 
        }

        /// <summary>
        /// Removes item from the stock.
        /// If item doesn't exist, does nothing.
        /// </summary>
        /// <param name="name"></param>
        public void Remove(string name)
        {
            for (int i = 0; i < Items.Count; i++)
            {
                if (name == Items[i].Name)
                {
                    Items.Remove(Items[i]);
                }
            }
        }

        /// <summary>
        /// Player can sell items to a shop.
        /// All items can be sold.
        /// Shop looses money.
        /// </summary>
        /// <returns>Price of an item.</returns>
        public decimal Buy(Item item)
        {
            var price = item.Price;

            if (price > Money)
            {
                return 0;
            }

            Money -= price;
            return price;
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
            var soldItems = new List<Item>(); 
            for (int i = 0; i < Items.Count; i++)
            {
                if (item == Items[i].Name)
                {
                    soldItems.Add(Items[i]); 
                }
            }
            Money += soldItems[0].Price;
            return soldItems[0];
        }
    }
}