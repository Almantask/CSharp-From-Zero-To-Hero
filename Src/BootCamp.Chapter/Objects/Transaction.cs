using System;

namespace BootCamp.Chapter.Objects
{
    public class Transaction
    {
        public string Shop { get; }
        public string City { get; }
        public string Street { get; }
        public string Item { get; }
        public DateTimeOffset DateTime { get; }
        public decimal Price { get; }
        
        public Transaction(string shop, string city, string street, string item, DateTimeOffset dateTime, decimal price)
        {
            Shop = shop ?? throw new ArgumentNullException(nameof(shop));
            City = city ?? throw new ArgumentNullException(nameof(city));
            Street = street ?? throw new ArgumentNullException(nameof(street));
            Item = item ?? throw new ArgumentNullException(nameof(item));
            DateTime = dateTime;
            Price = price;
        }
    }
}
