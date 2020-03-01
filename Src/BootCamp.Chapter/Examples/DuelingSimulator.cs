using System;
using System.Drawing;
using BootCamp.Chapter.Combat;

namespace BootCamp.Chapter.Examples
{
    public static class DuelingSimulator
    {
        public static void Run()
        {
            ICombatant[] combatants = CreateCombatants();
            var gladiator = combatants[0];
            var snorlack = combatants[1];

            var round = 0;
            while (gladiator.GetHitPoints() > 0 && snorlack.GetHitPoints() > 0)
            {
                AnnounceRound(round);
                Fight(gladiator, snorlack);
                ReportRound(gladiator, snorlack);
                round++;
            }

            AnnounceWinner(gladiator, snorlack);
        }

        private static void Fight(ICombatant gladiator, ICombatant snorlack)
        {
            gladiator.Attack(snorlack);
            snorlack.Attack(gladiator);
        }

        private static void ReportRound(ICombatant gladiator, ICombatant snorlack)
        {
            if (gladiator.GetHitPoints() > snorlack.GetHitPoints())
            {
                AnnounceWinning(gladiator, nameof(gladiator));
                Console.Write(", ");
                AnnounceLoosing(snorlack, nameof(snorlack));
            }
            else if (gladiator.GetHitPoints() < snorlack.GetHitPoints())
            {
                AnnounceLoosing(gladiator, nameof(gladiator));
                Console.Write(", ");
                AnnounceWinning(snorlack, nameof(snorlack));
            }
            else
            {
                AnnounceDraw(gladiator, snorlack);
            }
            Console.WriteLine();
        }

        private static void AnnounceWinning(ICombatant combatant, string name)
        {
            AnnounceInColoredHp(combatant, name, ConsoleColor.Yellow);
        }

        private static void AnnounceLoosing(ICombatant combatant, string name)
        {
            AnnounceInColoredHp(combatant, name, ConsoleColor.Red);
        }

        private static void AnnounceInColoredHp(ICombatant combatant, string name, ConsoleColor color)
        {
            Console.Write($"{name}: ");
            Console.ForegroundColor = color;
            Console.Write($"{combatant.GetHitPoints()} hp");
            Console.ResetColor();
        }

        private static void AnnounceDraw(ICombatant combatant1, ICombatant combatant2)
        {
            Console.Write($"Gladiator: {combatant1.GetHitPoints()} hp");
            Console.Write($"Snorlack: {combatant2.GetHitPoints()} hp.");
        }

        private static void AnnounceRound(int round)
        {
            Console.WriteLine($"Round {round} is about to start.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.WriteLine();
        }

        private static ICombatant[] CreateCombatants()
        {
            var gladiator = new Human(100, new Sword(), new ChainMain(), Point.Empty);
            var pokemon = new Pokemon(100, new IAttack[] { new Slash(), new Punch() }, Point.Empty);

            return new ICombatant[] { gladiator, pokemon };
        }

        private static void AnnounceWinner(ICombatant gladiator, ICombatant snorlack)
        {
            var winner = "";
            if (gladiator.GetHitPoints() > snorlack.GetHitPoints())
            {
                winner = "Gladiator";
            }
            else
            {
                winner = "Snorlack";
            }

            Console.Write("The winner is: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(winner);
            Console.ResetColor();
        }
    }
}
