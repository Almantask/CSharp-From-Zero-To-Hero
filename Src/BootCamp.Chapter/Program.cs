using BootCamp.Chapter.Items;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Item sword = new Item("sword", 20, 5);
            Item longSword = new Item("longsword", 40, 10);

            Inventory playerInventory = new Inventory();

            playerInventory.AddItem(sword);
            playerInventory.AddItem(longSword);

            string swordString = "sword";

            playerInventory.GetItems(swordString);

            Player p1 = new Player();

            //p1.AddItem(sword);
            //p1.AddItem(longSword);
            //p1.AddItem(sword);
            ////p1.AddItem(sword);
            ////p1.AddItem(sword);
            //p1.AddItem(longSword);
            //p1.AddItem(longSword);

            Weapon _sword = new Weapon("_sword", 20, 2, 15);
            Headpiece _helmet = new Headpiece("Iron helmet", 5, 5, 5);
            Armpiece _leftArmpiece = new Armpiece("Iron armpiece left", 5, 5, 5);
            Armpiece _rightArmpiece = new Armpiece("Iron armpiece right", 5, 5, 5);
            Chestpiece _chestpiece = new Chestpiece("Iron chestpiece", 15, 15, 15);
            Gloves _gloves = new Gloves("Iron gloves", 1, 1, 1);
            Shoulderpiece _leftShoulderpiece = new Shoulderpiece("Iron shoulderpiece left", 3, 3, 3);
            Shoulderpiece _rightShoulderpiece = new Shoulderpiece("Iron shoulderpiece right", 3, 3, 3);
            Legspiece _legs = new Legspiece("Iron legspiece", 10, 10, 10);

            p1.AddItem(_sword);
            p1.AddItem(_helmet);
            p1.AddItem(_leftArmpiece);
            p1.AddItem(_rightArmpiece);
            p1.AddItem(_chestpiece);
            p1.AddItem(_gloves);
            p1.AddItem(_leftShoulderpiece);
            p1.AddItem(_rightShoulderpiece);
            p1.AddItem(_legs);

            p1.Equip(_sword);
            p1.Equip(_helmet);
            p1.Equip(_chestpiece);
            p1.Equip(_leftArmpiece, true);
            p1.Equip(_rightArmpiece, false);
            p1.Equip(_gloves);
            p1.Equip(_leftShoulderpiece, true);
            p1.Equip(_rightShoulderpiece, false);
            p1.Equip(_legs);

            p1.GetItems();

            Console.WriteLine("Total attack: {0}", p1.GetTotalPlayerAttack());
            Console.WriteLine("Total defense: {0}", p1.GetTotalPlayerDefense());



            Console.ReadKey();
        }
    }
}
