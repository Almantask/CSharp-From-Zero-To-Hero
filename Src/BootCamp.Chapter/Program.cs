using BootCamp.Chapter.Items;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop(100000);

            Item sword = new Item("swordFromShop", 20, 5);
            Item longSword = new Item("longswordFromShop", 40, 10);

            shop?.Add(sword);
            shop?.Add(longSword);

            //Inventory playerInventory = new Inventory();
            //string swordString = "sword";
            //playerInventory.GetItems(swordString);

            Player p1 = new Player();

            p1?.BuyItemFromShop(sword, shop);
            p1?.BuyItemFromShop(longSword, shop);

            p1?.SellItemToShop(sword, shop);
            p1?.SellItemToShop(longSword, shop);

            Weapon _sword;
            Headpiece _helmet;
            Armpiece _leftArmpiece, _rightArmpiece;
            Chestpiece _chestpiece;
            Gloves _gloves;
            Shoulderpiece _leftShoulderpiece, _rightShoulderpiece;
            Legspiece _legs;

            CreateArmorAndWeapons(out _sword, out _helmet, out _leftArmpiece, out _rightArmpiece, out _chestpiece, out _gloves, out _leftShoulderpiece, out _rightShoulderpiece, out _legs);

            AddItemsToInventoryAndEquip(p1, _sword, _helmet, _leftArmpiece, _rightArmpiece, _chestpiece, _gloves, _leftShoulderpiece, _rightShoulderpiece, _legs);

            Console.WriteLine("Total attack: {0}", p1?.GetTotalPlayerAttack());
            Console.WriteLine("Total defense: {0}", p1?.GetTotalPlayerDefense());

            Console.ReadKey();
        }

        private static void AddItemsToInventoryAndEquip(Player p1, Weapon _sword, Headpiece _helmet, Armpiece _leftArmpiece, Armpiece _rightArmpiece, Chestpiece _chestpiece, Gloves _gloves, Shoulderpiece _leftShoulderpiece, Shoulderpiece _rightShoulderpiece, Legspiece _legs)
        {
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
        }

        private static void CreateArmorAndWeapons(out Weapon _sword, out Headpiece _helmet, out Armpiece _leftArmpiece, out Armpiece _rightArmpiece, out Chestpiece _chestpiece, out Gloves _gloves, out Shoulderpiece _leftShoulderpiece, out Shoulderpiece _rightShoulderpiece, out Legspiece _legs)
        {
            _sword = new Weapon("_sword", 20, 2, 15);
            _helmet = new Headpiece("Iron helmet", 5, 5, 5);
            _leftArmpiece = new Armpiece("Iron armpiece left", 5, 5, 5);
            _rightArmpiece = new Armpiece("Iron armpiece right", 5, 5, 5);
            _chestpiece = new Chestpiece("Iron chestpiece", 15, 15, 15);
            _gloves = new Gloves("Iron gloves", 1, 1, 1);
            _leftShoulderpiece = new Shoulderpiece("Iron shoulderpiece left", 3, 3, 3);
            _rightShoulderpiece = new Shoulderpiece("Iron shoulderpiece right", 3, 3, 3);
            _legs = new Legspiece("Iron legspiece", 10, 10, 10);
        }
    }
}
