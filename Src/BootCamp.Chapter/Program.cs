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
            shop.Add(item3);
            shop.Remove(null);

        }
    }
}
