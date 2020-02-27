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

        public Item[] AddItem(Item[] oldArray,  Item item)
        {
            var newArray = new Item[oldArray.Length + 1];
            for (int i = 0; i <= oldArray.Length - 1; i++)
            {
                newArray[i] = oldArray[i];
            }
            newArray[^1] = item;
            return newArray;
        }

        internal static Item[] RemoveByBame(Item[] oldArray,  string name)
        {
            var newArray = new Item[oldArray.Length - 1];
            var found = false;
            for (int i = 0; i < oldArray.Length; i++)
            {
                if (oldArray[i].GetName() == name)
                {
                    found = true;
                    continue; 
                }

                if (found)
                {
                    newArray[i - 1] = oldArray[i]; 
                }
                else
                {
                    newArray[i] = oldArray[i]; 
                }
            }

            return newArray; 
        }

        internal static Item[] RemoveFromArray(Item[] items, Item item)
        {
            if (items.Length == 0)
            {
                return items;
            }

            var newArray = new Item[ items.Length - 1];
            var found = false; 
            for (int i = 0; i < items.Length - 1; i++)
            {
                if (items[i] == item)
                {
                    found = true;
                    continue;
                }

                if (found)
                {
                    newArray[i - 1] = items[i];
                }
                else
                {
                    newArray[i] = items[i];
                }
            }

            return newArray;
        }
    }
}