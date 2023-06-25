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

    public Item(string name, decimal price = 0, float weight = 0)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }

		public override bool Equals(object obj)
		{
			//False if obj is null or isn't an Item
            if (obj == null || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }

            //Only need to compare names
            Item item = (Item)obj;
            return _name.Equals(item._name);
		}
	}
}