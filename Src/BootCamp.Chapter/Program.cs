using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player Tailor = new Player("Tailor", 10, 5);
            
            var potion = new Item("Health potion", 15, 0.2f);
            Tailor.AddItem(potion);

            var shoulderPiece = new Shoulderpiece("ShoulderPiece left", 10, 5, 0.8f);
            Tailor.AddItem(shoulderPiece);
            Tailor.Equip(shoulderPiece, true);

            shoulderPiece = new Shoulderpiece("ShoulderPiece right", 10, 5, 0.8f);
            Tailor.AddItem(shoulderPiece);
            Tailor.Equip(shoulderPiece, false);

            var chestPlate = new Chestpiece("Chestplate", 20, 10, 3f);
            Tailor.AddItem(chestPlate);
            Tailor.Equip(chestPlate);

            var sword = new Weapon("Stormbringer", 50, 20, 10);
            Tailor.AddItem(sword);
            Tailor.Equip(sword);

            System.Console.WriteLine(Tailor);

        }
    }
}
