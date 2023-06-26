using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BootCamp.Chapter
{
    public class Inventory
	{
		public Item[] Items { get; private set; }

		public Inventory()
		{
			Items = new Item[0];
		}

		public Item[] GetItems(string name)
		{
			//Throw exception if name is null or blank
			if (string.IsNullOrEmpty(name))
			{
				throw new ArgumentNullException(nameof(name));
			}

			Item searchItem = new Item(name);

			//Return if the item doesn't exist
			if (!Items.Contains(searchItem))
			{
				return new Item[0];
			}

			//Find the items
			List<Item> foundItems = new List<Item>();
			foreach (Item item in Items)
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
			//Throw exception if null
			_ = item ?? throw new ArgumentNullException(nameof(item));

			//Make new array to add the item
			Item[] newItems = new Item[Items.Length + 1];
			//Copy existing items
			for (int i = 0; i < Items.Length; i++)
			{
				newItems[i] = Items[i];
			}
			//Add new item
			newItems[^1] = item;
			//Set the array as the main array
			Items = newItems;
		}

		/// <summary>
		/// Removes item matching criteria by item.
		/// Does nothing if no such item exists
		/// </summary>
		public void RemoveItem(Item item)
		{
			//Throw exception if null
			_ = item ?? throw new ArgumentNullException(nameof(item));

			//Number of item instances
			int itemCount = Items.Count(i => i.Equals(item));

			//Return if the item doesn't exist
			if (itemCount == 0)
			{
				return;
			}

			//Make new array to hold -1 element
			Item[] newItems = new Item[Items.Length - itemCount];
			//Copy existing items until we reach the item to remove
			int newIndex = 0;
			for (int existingIndex = 0; existingIndex < Items.Length; existingIndex++)
			{
				//Skip if it's the removed item
				if (Items[existingIndex].Equals(item))
				{
					continue;
				}

				newItems[newIndex] = Items[existingIndex];
				newIndex++;
			}

			Items = newItems;
		}
	}
}
