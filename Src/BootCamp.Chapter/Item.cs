using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public double Weight { get; }

        public Item(string name, decimal price, double weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
