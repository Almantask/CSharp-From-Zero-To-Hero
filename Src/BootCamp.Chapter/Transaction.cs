using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace BootCamp.Chapter
{
    public class Transaction
    {
        [JsonProperty(PropertyName = "Shop")]
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string SoldItem { get; set; }
        public DateTime TimeWhenSold { get; set; }
        public decimal TotalPrice { get; set; }
    }
}