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
        public bool Equals(Item other)
        {
            if (other is null)
                return false;

            return this.Name == other.Name && this.Price == other.Price && this.Weight == other.Weight;
        }

        public override bool Equals(object obj) => Equals(obj as Item);
        public override int GetHashCode() => (Name, Price, Weight).GetHashCode();
    }
}
