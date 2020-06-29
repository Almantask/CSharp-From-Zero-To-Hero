using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class TransactionModeljson
    {
        public string ShopName { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string Item { get; set; }
        public string DateTime { get; set; }
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{ShopName},{City},{Street},{Item},{DateTime},{Price}";
        }
    }
}