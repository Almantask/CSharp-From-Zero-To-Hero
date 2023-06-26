using System;

namespace BootCamp.Chapter
{
	public class Item
	{
		public string Name { get; private set; }

		public decimal Price { get; private set; }

		public float Weight { get; private set; }

		public Item(string name, decimal price = 0, float weight = 0)
		{
			Name = name ?? throw new ArgumentNullException(nameof(name));
			Price = price;
			Weight = weight;
		}

		public override bool Equals(object obj)
		{
			//False if obj is null or isn't an Item
			if (obj is null || !(obj is Item))
			{
				return false;
			}

			//Only need to compare names
			Item item = (Item)obj;
			return Name.Equals(item.Name);
		}
	}
}