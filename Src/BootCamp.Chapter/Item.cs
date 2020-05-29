using System;

namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; set; }

        public decimal Price { get; set; }

        public float Weight { get; set; }

        public Item(string? name, decimal price, float weight)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name) + " shouldn't be null.");
            Price = price;
            Weight = weight;
        }
    }
}