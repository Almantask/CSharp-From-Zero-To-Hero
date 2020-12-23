using System;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop(100);
            var item2 = new Item("Potion", 20, 0.2f);
            Item item3 = null;
            shop.Add(item2);
            WriteLine(shop.Items.Count);
            foreach(var item in shop.Items)
            {
                WriteLine(item.Name);
            }
            shop.Remove(item2.Name);
            Write(shop.Items.Count);

        }
    }
}
