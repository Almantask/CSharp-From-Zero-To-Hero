using System;
using Newtonsoft.Json;

namespace BootCamp.Chapter.Examples.Json.Common.Models
{
    public class Item
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonIgnore]
        public string Description { get; set; }
        public DateTime DataOfMaking { get; set; }
    }
}
