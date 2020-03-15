using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public abstract class Armor : Item
    {
        public float Defence { get; }
        public Armor(string name, decimal price, float weight, float defence) : base(name, price, weight)
        {
            Defence = defence;
        }
    }
}
