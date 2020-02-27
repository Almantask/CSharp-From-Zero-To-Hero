using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inv = new Inventory();
            var item1 = new Item("kelnis", 1, 1);
            var item2 = new Item("kelnis7", 2, 1);
            //// Item[] foo = new Item[] { new Item("kelnis", 2, 1), new Item("kelnis", 3, 1), new Item("kelnis", 4, 1) };
            //Item[] foo = new Item[0];
            //Console.WriteLine(foo.Length);
            //foo = new Item[foo.Length + 1];
            //Console.WriteLine(foo.Length);
            //foo[^1] = item1;
            //Console.WriteLine(foo.Length);

            inv.AddItem(item1);
            inv.AddItem(new Item("kelnis", 2, 1));
            inv.AddItem(new Item("kelnis2", 3, 1));
            inv.AddItem(new Item("kelniss", 4, 1));

            //  inv.RemoveItem(item2);
            // var foo =  RemoveAt(inv.GetItems(), 3);

            int i = 0;
            foreach (var item in inv.GetItems("kelnis"))
            {
                Console.WriteLine(i + item.GetName());
                i++;
            }

            PrintInventory(inv);

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
