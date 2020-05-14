using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Armor : Item
    {
        public float DefenseValue { get; private set; }

        public Armor(string name, decimal price, float weight, float defenseValue) : base(name, price, weight)
        {
            DefenseValue = defenseValue;
        }
    }
}