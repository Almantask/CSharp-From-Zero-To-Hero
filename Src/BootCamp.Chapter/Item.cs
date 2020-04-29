using System;

namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; }
        public decimal Price { get; }
        public float Weight { get; }
        
        public Item(string name, decimal price, float weight)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}