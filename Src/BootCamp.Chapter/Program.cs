using System;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            Player player = new Player("Matthew");
            Chestpiece chestPiece = new Chestpiece("Mighty Chestpiece",100, 10);
            player.AddItem(chestPiece);
            player.ShowInventory();
            player.Remove(chestPiece);
            player.ShowInventory();
            Console.WriteLine($"{chestPiece.Price}");
            Shop shop = new Shop(100);
            shop.Add(chestPiece);
            shop.Sell("Mighty Chestpiece");
            Console.WriteLine($"{shop.Money}");

        }
    }
}
