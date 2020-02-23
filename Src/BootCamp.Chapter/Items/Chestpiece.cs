using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Items
{
    public class Chestpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Chestpiece(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
