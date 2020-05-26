using System;

namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }

        public Item(string name, decimal price, float weight)
        {
            Name = name ?? throw new ArgumentNullException($"{nameof(Name)} cannot be null.");
            Price = price <= 0 ? price : throw new ArgumentException($"{nameof(Price)} cannot be less than or equal to 0.");
            Weight = weight < 0 ? weight : throw new ArgumentException($"{nameof(Weight)} cannot be less then 0.");
        }
    }
}