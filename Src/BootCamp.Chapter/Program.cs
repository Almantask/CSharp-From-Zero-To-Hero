using System;
using static System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var player = new Player();
            var item = new Item("Potion", 20, 0.2f);
            player.AddItem(item);

            var items = player.GetItems(item.GetName());
            if (items != null)
                Write(123);
        }
    }
}
