using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Tailor = new Player("Tailor", 10, 5);

            Shop shop = new Shop(500);
            shop.Add(new Item("Health potion", 15, 0.2f));
            shop.Add(new Weapon("Stormbringer", 50, 20, 10));
            shop.Add(new Weapon("Gorgoyles bane", 60, 25, 15));
            Tailor.AddItem(shop.Sell("Health potion"));

            var sword = shop.Sell("Stormbringer");
            Tailor.AddItem(sword);
            Tailor.Equip((Weapon)sword);

            var shoulderPiece = new Shoulderpiece("ShoulderPiece left", 10, 5, 0.8f);
            Tailor.AddItem(shoulderPiece);
            Tailor.Equip(shoulderPiece, true);

            shoulderPiece = new Shoulderpiece("ShoulderPiece right", 10, 5, 0.8f);
            Tailor.AddItem(shoulderPiece);
            Tailor.Equip(shoulderPiece, false);

            var chestPlate = new Chestpiece("Chestplate", 20, 10, 3f);
            Tailor.AddItem(chestPlate);
            Tailor.Equip(chestPlate);

            System.Console.WriteLine(Tailor);
            System.Console.WriteLine(shop);
        }
    }
}