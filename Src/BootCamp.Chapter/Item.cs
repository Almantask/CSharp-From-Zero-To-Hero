using System;

namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get;}
        public decimal Price { get;}
        public float Weight { get;}

        public Item(string name, decimal price, float weight)
        {
            Name = name ?? throw new ArgumentNullException($"{nameof(name)} cannot be empty");
            Price = price;
            Weight = weight;
        }
        public bool IsTheSameItem(Item item)
        {
            if (this == item)
            {
                return true;
            }
            return false;
        }
    }
}