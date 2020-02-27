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
        public float GetWeight()
        {
            return _weight;
        }

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }

        public static Item[] Append(Item[] array, Item toAppend)
        {
            var newArray = new Item[1 + array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            newArray[^1] = toAppend;
            return newArray;

        }

        public static bool ItemInArray(Item[] array, Item searchItem)
        {
            bool itemInArray = false;
            foreach (Item item in array)
            {
                if (item == searchItem)
                {
                    itemInArray = true;
                }
            }
            return itemInArray;
        }

        public static Item[] RemoveItem(Item[] array, Item toRemove)
        {
            // there is a likelyhood that the item to remove is not in the array, in that case it should just return original array
            bool itemInArray = ItemInArray(array, toRemove);
            if (!itemInArray)
            {
                return array;
            }

            bool itemRemoved = false;
            var newArray = new Item[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (array[i] == toRemove)
                {
                    itemRemoved = true;
                }

                newArray[i] = itemRemoved ? array[i + 1] : array[i];
            }
            return newArray;
        }

        public static bool NameInArray(Item[] array, string name)
        {
            bool inArray = false;
            foreach (Item item in array)
            {
                if (item.GetName() == name)
                {
                    inArray = true;
                }
            }
            return inArray;
        }

        public static Item[] RemoveName(Item[] array, string name)
        {
            bool itemInArray = NameInArray(array, name);
            if (!itemInArray)
            {
                return array;
            }

            bool itemRemoved = false;
            var newArray = new Item[array.Length - 1];
            for (int i = 0; i < newArray.Length; i++)
            {
                if (array[i].GetName() == name)
                {
                    itemRemoved = true;
                }
                newArray[i] = itemRemoved ? array[i] : array[i + 1];
            }
            return newArray;
        }
    }
}