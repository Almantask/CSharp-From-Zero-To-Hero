using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Item
    {
        public string Name { get; }
        public float Weight { get; }
        public decimal Price { get; }

        public Item(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
