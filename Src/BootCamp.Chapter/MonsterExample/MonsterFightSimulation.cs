using System;

namespace BootCamp.Chapter
{
    static class MonsterFightSimulation
    {
        public static void Run()
        {
            var factory = new MonsterFactory();
            var monster1 = factory.Create();
            var monster2 = factory.Create();

            while (monster1.IsAlive && monster2.IsAlive)
            {
                monster1.Attack(monster2);
                monster2.Attack(monster1);
            }

            monster1.Attack(monster2);
            monster2.Attack(monster1);

            Console.WriteLine("The fight is over!");
        }
    }
}