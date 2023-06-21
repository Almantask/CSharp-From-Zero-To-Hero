using System.Linq;

namespace BootCamp.Chapter
{
	public class Shop
	{
		private decimal _money = 0;
		public decimal GetMoney()
		{
			return _money;
		}

		private Inventory _inventory;

		public Shop()
		{
			_inventory = new Inventory();
		}

		public Shop(decimal money) : this()
		{
			_money = money;
		}

		public Item[] GetItems()
		{
			return _inventory.GetItems();
		}

		/// <summary>
		/// Adds item to the stock.
		/// If item of same name exists, does nothing.
		/// </summary>
		public void Add(Item item)
		{
			//Return if item already exists
			if (_inventory.GetItems().Contains(item))
			{
				return;
			}
			//Add item
			_inventory.AddItem(item);
		}

		/// <summary>
		/// Removes item from the stock.
		/// If item doesn't exist, does nothing.
		/// </summary>
		/// <param name="name"></param>
		public void Remove(string name)
		{
			_inventory.RemoveItem(new Item(name));
		}

		/// <summary>
		/// Player can sell items to a shop.
		/// All items can be sold.
		/// Shop looses money.
		/// </summary>
		/// <returns>Price of an item.</returns>
		public decimal Buy(Item item)
		{
			decimal itemPrice = item.GetPrice();

			//Return 0 if we don't have enough money to buy
			if (itemPrice > _money)
			{
				return 0;
			}
			
			//Update money
			_money -= itemPrice;

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
			Item[] soldItem = _inventory.GetItems(item);

			//Return if no item found or more than 1 was found
			if (soldItem == null || soldItem.Length != 1)
			{
				return null;
			}

			//Add cost to money
			_money += soldItem[0].GetPrice();

			return soldItem[0];
		}
	}
}