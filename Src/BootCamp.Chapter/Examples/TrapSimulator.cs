using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Armour;
using BootCamp.Chapter.Combat.Attacks;
using BootCamp.Chapter.Combat.Combatants;
using BootCamp.Chapter.Combat.Combatants.Traps;

namespace BootCamp.Chapter.Examples
{
    static class TrapSimulator
    {
        private const int RangeX = 20;
        private const int RangeY = 20;

        public static void Run()
        {
            //var human = new Human(10000, null, new ChainMail(), new Point(0, 10));
            //var dummy = new Dummy(new Point(RangeX, RangeY));
            var pokemon = new Pokemon(1000, new IAttack[] {new Slash()}, Point.Empty);

            var traps = new Trap[]
            {
                new BladeTrap(new Point(0, 0)),
                new BladeTrap(new Point(0, RangeY)),
                new BladeTrap(new Point(RangeX, 0)),
                new BladeTrap(new Point(RangeX, RangeY)),
                new PunchTrap(new Point(RangeX / 2, RangeY / 2)),
                new PunchTrap(new Point(RangeX / 5, RangeY / 2)),
                new PunchTrap(new Point(RangeX / 10, RangeY / 4)),
                new PunchTrap(new Point(0, RangeY / 2)),
                new SpitTrap(new Point(RangeX / 4, RangeY / 2))
            };

            StepToYourDeath(pokemon, traps);
        }

        private static void StepToYourDeath(IPrey dummy, Trap[] traps)
        {
            var random = new Random();
            while (dummy.GetHitPoints() > 0)
            {
                var x = random.Next(RangeX + 1);
                var y = random.Next(RangeY + 1);
                var nextPosition = new Point(x, y);
                StepCarefuly(dummy, traps, nextPosition);
                ReportStus(dummy, nextPosition);
            }
        }

        private static void ReportStus(IPrey dummy, Point position)
        {
            Console.WriteLine($"Dummy stepped at position: {position}.");
            Console.WriteLine($"Dummy has {dummy.GetHitPoints()} hp.");
        }

        private static void StepCarefuly(IPrey dummy, Trap[] traps, Point position)
        {
            dummy.Move(position);

            foreach (var trap in traps)
            {
                var initialHp = dummy.GetHitPoints();
                trap.Attack(dummy);
                var wasHit = dummy.GetHitPoints() < initialHp;

                if (wasHit)
                {
                    ReportTrap(trap.GetType().Name);
                }
            }
        }

        private static void ReportTrap(string trap)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Oops! ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(trap);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" got triggered!");
            Console.ResetColor();
            Console.WriteLine();
        }
    }

    class Dummy : IPrey
    {
        private float _hitpoints;
        private Point _position;
        public Point GetPosition()
        {
            return _position;
        }

        public void Move(Point position)
        {
            _position = position; 
        }

        public Dummy(Point position)
        {
            _position = position;
            _hitpoints = 1000;
        }

        public float GetHitPoints()
        {
            return _hitpoints;
        }

        public void DefendFrom(IAttack attack)
        {
            _hitpoints -= attack.GetDamage();
        }


    }
}
