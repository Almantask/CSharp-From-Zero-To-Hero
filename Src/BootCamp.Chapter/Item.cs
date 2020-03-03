using System;

namespace BootCamp.Chapter
{
    public class Item
    {
        private string _name;
        public string GetName()
        {
            return _name;
        }

        private decimal _price;
        public decimal GetPrice()
        {
            return _price;
        }

        private float _weight;

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }

        

        

        
    }
}