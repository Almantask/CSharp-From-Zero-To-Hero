using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Armor : Item
    {
        private float _defenseValue;

        public float GetDefenseValue()
        {
            return _defenseValue;
        }

        public Armor(string name, decimal price, float weight, float defenseValue) : base(name, price, weight)
        {
            _defenseValue = defenseValue;
        }
    }
}
