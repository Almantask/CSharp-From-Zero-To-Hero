using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class AsymetricalArmor : Armor
    {
        bool _isLeft;
        public bool GetIsLeft()
        {
            return _isLeft;
        }

        public AsymetricalArmor(string name, decimal price, float weight, float defence, bool isLeft) : base(name, price, weight, defence)
        {
            _isLeft = isLeft;
        }
    }
}
