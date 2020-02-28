using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop();
            var item1 = new Item("kelnis", 1, 1);
            var item2 = new Item("kelnis7", 2, 1);
            //// Item[] foo = new Item[] { new Item("kelnis", 2, 1), new Item("kelnis", 3, 1), new Item("kelnis", 4, 1) };
            //Item[] foo = new Item[0];
            //Console.WriteLine(foo.Length);
            //foo = new Item[foo.Length + 1];
            //Console.WriteLine(foo.Length);
            //foo[^1] = item1;
            //Console.WriteLine(foo.Length);

            shop.Add(item1);
            shop.Add(new Item("kelnis", 2, 1));
            shop.Add(new Item("kelnis2", 3, 1));
            shop.Add(new Item("kelniss", 4, 1));

            //  inv.RemoveItem(item2);
            // var foo =  RemoveAt(inv.GetItems(), 3);
            shop.Remove("kelnis");
            foreach (var item in shop.GetItems())
            {
                System.Console.WriteLine(item.GetName() + "   " + item.GetPrice());
            }

            // PrintInventory(shop);

        }
        public static Item[] RemoveAt(Item[] array, int index)
        {
            var amendedArray = new Item[array.Length - 1];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (i >= index)
                {
                    amendedArray[i] = array[i + 1];
                    continue;
                }
                amendedArray[i] = array[i];
            }
            return amendedArray;
        }

        static void PrintInventory(Inventory inv)
        {
            foreach (var item in inv.GetItems())
            {
                System.Console.WriteLine(item.GetName() + "   " + item.GetPrice());
            }
        }
    }
}
