using System;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var sword = new Weapon("StarForger", 21m, 98.6f, 3);
            var mjolnir = new Weapon("Mjolnir", 99999999m, 999999999, 999999999);
            var mantle = new Chestpiece("Mantle", 35m, 3f, 2);
            var armour = new Chestpiece("Plate", 259M, 15f, 25);
            
            var bag = new Inventory();
            bag.AddItem(mantle);
            bag.AddItem(armour);
            bag.AddItem(mantle);
            bag.RemoveItem(mantle);
            
            var player = new Player("Tom", 352, 10);
            player.AddItem(mantle);
            player.EquipChest(mantle);
            player.EquipChest(null);
            
            player.EquipWeapon(sword);
            player.EquipWeapon(mjolnir);
            player.EquipWeapon(null);
            
            Console.Read();
        }
    }
}
