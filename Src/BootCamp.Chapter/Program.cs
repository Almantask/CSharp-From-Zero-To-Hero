using BootCamp.Chapter.Items;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Item sword = new Item("sword", 20, 2);
            Item longSword = new Item("longsword", 40, 5);

            Inventory playerInventory = new Inventory();

            playerInventory.AddItem(sword);
            playerInventory.AddItem(longSword);

            string swordString = "sword";

            playerInventory.GetItems(swordString);

            Player p1 = new Player();

            Weapon _sword = new Weapon("sword", 20, 2, 15);
            p1.Equip(_sword);
            p1.GetItems();
            


            Console.WriteLine("Total attack: {0}", p1.GetTotalPlayerAttack());
            Console.WriteLine("Total defense: {0}", p1.GetTotalPlayerDefense());



            Console.ReadKey();
        }
    }
}
