using System.Linq;

namespace BootCamp.Chapter
{
    public class Shop
	{
		public decimal Money { get; private set; } = 0;

		private Inventory Inventory { get;  set; }
		public Item[] Items { get { return Inventory.Items; } }

		public Shop()
		{
			Inventory = new Inventory();
		}

		public Shop(decimal money) : this()
		{
			Money = money;
		}

		/// <summary>
		/// Adds item to the stock.
		/// If item of same name exists, does nothing.
		/// </summary>
		public void Add(Item item)
		{
			//Return if item already exists
			if (Inventory.Items.Contains(item))
			{
				return;
			}
			//Add item
			Inventory.AddItem(item);
		}

		/// <summary>
		/// Removes item from the stock.
		/// If item doesn't exist, does nothing.
		/// </summary>
		/// <param name="name"></param>
		public void Remove(string name)
		{
			Inventory.RemoveItem(new Item(name));
		}

		/// <summary>
		/// Player can sell items to a shop.
		/// All items can be sold.
		/// Shop looses money.
		/// </summary>
		/// <returns>Price of an item.</returns>
		public decimal Buy(Item item)
		{
			decimal itemPrice = item.Price;

			//Return 0 if we don't have enough money to buy
			if (itemPrice > Money)
			{
				return 0;
			}

			//Update money
			Money -= itemPrice;

			return itemPrice;
		}

		/// <summary>
		/// Sell item from a shop.
		/// Shop increases it's money.
		/// No money is increased if item does not exist.
		/// </summary>
		/// <returns>
		/// Item sold.
		/// Null, if no item is sold.
		/// </returns>
		public Item Sell(string item)
		{
			Item[] soldItem = Inventory.GetItems(item);

			//Return if no item found or more than 1 was found
			if (soldItem == null || soldItem.Length != 1)
			{
				return null;
			}

			//Add cost to money
			Money += soldItem[0].Price;

			return soldItem[0];
		}
	}
}