using System;

namespace BootCamp.Chapter
{
    class MonsterFactory
    {
        private readonly Random _random = new Random();

        private string[] _names = {"Bill", "Xxxxa", "Ells", "Mu"};
        private int monstersCreated = 0;

        public Monster Create()
        {
            var nameIndex = _random.Next(_names.Length);
            var monster = new Monster(_names[nameIndex]+ monstersCreated);
            monstersCreated++;
            monster.OnDead += PrintDeadMonster;
            monster.OnMonsterHit += PrintMonsterLife;

            return monster;
        }

        private void PrintMonsterLife(object sender, OnMonsterHitEventArgs e)
        {
            var monster = sender as Monster;
            Console.WriteLine($"Monster {monster.Name} got hit with {e.DamageTaken}.");
        }

        private void PrintDeadMonster(object sender, EventArgs e)
        {
            var monster = sender as Monster;
            Console.WriteLine($"Monster {monster.Name} died. {DateTime.Now}");
            monster.OnDead -= PrintDeadMonster;
            monster.OnMonsterHit -= PrintMonsterLife;
        }
    }
}