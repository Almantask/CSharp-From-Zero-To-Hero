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
        public readonly string StreetName;

        public Transaction(string itemName, DateTime timePurchased, decimal price, string shopName, string location, string streetName)
        {
            ItemName = itemName;
            TimePurchased = timePurchased;
            Price = price;
            ShopName = shopName;
            Location = location;
            StreetName = streetName;
        }
    }
}
