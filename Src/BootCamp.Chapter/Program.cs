using System;
using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player("Arthas Menethil", 50, 10, new Inventory(), new Equipment());
            EquipItems_And_DisplayStatistics(playerOne);
        }

        // This code is ugly but it properly displays the stats of the player after items are equipped.
        private static void EquipItems_And_DisplayStatistics(Player player)
        {
            Console.WriteLine($"New player '{player.GetName()}' has been created.");
            Console.WriteLine($"Stats# HP: {player.GetHP()} | STR: {player.GetStrength()} | Max Carry Capacity: {player.GetCarryCapacity()} \n");

            Weapon sword = new Weapon("Frostmourne", 55.5m, 4.5f, 15.0f);
            player.Equip(sword);
            WriteStatsToConsole(player, sword);

            Headpiece head = new Headpiece("Icecrown Helmet", 50.0m, 10.0f, 15.0f);
            player.Equip(head);
            WriteStatsToConsole(player, head);

            Shoulderpiece shoulderpieceLeft = new Shoulderpiece("Shoulders of Ice (left)", 15.0m, 5.0f, 5.0f);
            player.Equip(shoulderpieceLeft, true);
            WriteStatsToConsole(player, shoulderpieceLeft);

            Shoulderpiece shoulderpieceRight = new Shoulderpiece("Shoulders of Ice (right)", 15.0m, 5.0f, 5.0f);
            player.Equip(shoulderpieceRight, false);
            WriteStatsToConsole(player, shoulderpieceRight);

            Chestpiece chestpiece = new Chestpiece("Breastplate of Sapphiron", 200.0m, 20.0f, 35.0f);
            player.Equip(chestpiece);
            WriteStatsToConsole(player, chestpiece);

            Gloves gloves = new Gloves("Gloves of Ice", 10.0m, 600.0f, 4.0f);
            player.Equip(gloves);
            WriteStatsToConsole(player, gloves);
        }

        private static void WriteStatsToConsole(Player player, Item item)
        {
            if (player.IsOverEncumbered(item))
            {
                Console.WriteLine($"'{player.GetName()}' tried equipping '{item.GetName()}'. Equipping failed: '{item.GetName()}' is too heavy ({item.GetWeight()}kg > {player.GetCarryCapacity()} max carry capacity)");
                return;
            }

            Console.Write($"'{player.GetName()}' has equipped '{item.GetName()}'");
            Console.WriteLine($" - the weight of items he's carrying has increased to {player.GetEquipment().GetTotalWeight()} kg");
            Console.WriteLine($"Stats# Total Weight Carried: {player.GetEquipment().GetTotalWeight()}kg | Total Defense: {player.GetEquipment().GetTotalDefense()} | Total Attack: {player.GetEquipment().GetTotalAttack()} \n");
        }
    }
}