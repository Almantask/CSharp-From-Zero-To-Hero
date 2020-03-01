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
                round++;
            }

            AnnounceWinner(gladiator, snorlack);
        }

        private static void Fight(ICombatant gladiator, ICombatant snorlack)
        {
            gladiator.Attack(snorlack);
            snorlack.Attack(gladiator);

            Console.WriteLine($"Gladiator: {gladiator.GetHitPoints()} hp, Snorlack: {snorlack.GetHitPoints()} hp.");
        }

        private static void AnnounceRound(int round)
        {
            Console.WriteLine($"Round {round} is about to start.");
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
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

            Console.WriteLine("The winner is: " + winner);
        }
    }
}
