using System;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Item { get; set; }
        public DateTimeOffset Time { get; set; }
        public decimal Price { get; set; }
    }
}
