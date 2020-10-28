using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Armour : Item
    {
        public float Defense { get; }

        public Armour(string name, decimal price, float weight, float defense) : base(name, price, weight)
        {
            Defense = defense;
        }
    }
}