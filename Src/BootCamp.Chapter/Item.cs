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
            Name = name ?? throw new ArgumentNullException("name");
            Price = price;
            Weight = weight;
        }
        public bool Equals(Item b)
        {
            if (this.Name == (b?.Name??throw new ArgumentNullException()) && this.Price ==( b?.Price??0) && this.Weight ==(b?.Weight??0))
                return true;
            return false;
        }
    }
}