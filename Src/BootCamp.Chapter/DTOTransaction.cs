using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public class DTOTransaction
    {
        [JsonProperty("Shop")]
        public string Shop { get; set; }
        [JsonProperty("City")]
        public string City { get; set; }
        [JsonProperty("Street")]
        public string Street { get; set; }
        [JsonProperty("Item")]
        public string Item { get; set; }
        [JsonProperty("DateTime")]
        public string DateTime { get; set; }
        [JsonProperty("Price")]
        public string Price { get; set; }

        public override string ToString()
        {
            return $"{Shop},{City},{Street},{Item},{DateTime},{Price}";
        }
    }
}