using System;

namespace BootCamp.Chapter
{
    class Transaction
    {
        public readonly string ItemName;
        public readonly DateTime TimePurchased;
        public readonly decimal Price;
        public readonly string ShopName;
        public readonly string Location;

        public Transaction(string itemName, DateTime timePurchased, decimal price, string shopName, string location)
        {
            ItemName = itemName;
            TimePurchased = timePurchased;
            Price = price;
            ShopName = shopName;
            Location = location;
        }
    }
}
