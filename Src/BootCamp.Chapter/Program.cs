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






            Console.ReadKey();
        }
    }
}
