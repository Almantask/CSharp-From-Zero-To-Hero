using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
	public class Inventory
	{
		private Item[] _items;
		public Item[] GetItems()
		{
			return _items;
		}

		public Inventory()
		{
			_items = new Item[0];
		}

		public Item[] GetItems(string name)
		{
			Item searchItem = new Item(name);

			//Return if the item doesn't exist
			if (!_items.Contains(searchItem))
			{
				return new Item[0];
			}
			
			//Find the items
			List<Item> foundItems = new List<Item>();
			foreach (Item item in _items)
			{
				if (item.Equals(searchItem))
				{
					foundItems.Add(item);
				}
			}

			return foundItems.ToArray();
		}

		public void AddItem(Item item)
		{
			//Make new array to add the item
			Item[] newItems = new Item[_items.Length + 1];
			//Copy existing items
			for (int i = 0; i < _items.Length; i++)
			{
				newItems[i] = _items[i];
			}
			//Add new item
			newItems[^1] = item;
			//Set the array as the main array
			_items = newItems;
		}

		/// <summary>
		/// Removes item matching criteria by item.
		/// Does nothing if no such item exists
		/// </summary>
		public void RemoveItem(Item item)
		{
			//Number of item instances
			int itemCount = _items.Count(i => i.Equals(item));

			//Return if the item doesn't exist
			if (itemCount == 0)
			{
				return;
			}

			//Make new array to hold -1 element
			Item[] newItems = new Item[_items.Length - itemCount];
			//Copy existing items until we reach the item to remove
			int newIndex = 0;
			for (int existingIndex = 0; existingIndex < _items.Length; existingIndex++)
			{
				//Skip if it's the removed item
				if (_items[existingIndex].Equals(item))
				{
					continue;
				}

				newItems[newIndex] = _items[existingIndex];
				newIndex++;
			}

			_items = newItems;
		}
	}
}
