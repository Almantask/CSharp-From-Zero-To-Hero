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
            Console.WriteLine($"New player '{player.Name}' has been created.");
            Console.WriteLine($"Stats# HP: {player.Hp} | STR: {player.Strength} | Max Carry Capacity: {player.MaxCarryCapacity} \n");

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
                Console.WriteLine($"'{player.Name}' tried equipping '{item.Name}'. Equipping failed: '{item.Name}' is too heavy ({item.Weight}kg > {player.MaxCarryCapacity} max carry capacity)");
                return;
            }

            Console.Write($"'{player.Name}' has equipped '{item.Name}'");
            Console.WriteLine($" - the weight of items he's carrying has increased to {player.Equipment.TotalCombinedWeight} kg");
            Console.WriteLine($"Stats# Total Weight Carried: {player.Equipment.TotalCombinedWeight}kg | Total Defense: {player.Equipment.TotalDefenseValue} | Total Attack: {player.Equipment.TotalAttackValue} \n");
        }
    }
}