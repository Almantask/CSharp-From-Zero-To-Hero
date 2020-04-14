using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string SoldItem { get; set; }
        public DateTime TimeWhenSold { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
