using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Armour : Item
    {
        private float _defense;

        public float GetDefense()
        {
            return _defense;
        }

        public Armour(string name, decimal price, float weight, float defense) : base(name, price, weight)
        {
            _defense = defense;
        }
    }
}
