using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Armor : Item
    {
        float _defence;
        public float GetDefence()
        {
            return _defence;
        }

        public Armor(string name, decimal price, float weight, float defence):base(name, price, weight)
        {
            _defence = defence;
        }
    }
}
