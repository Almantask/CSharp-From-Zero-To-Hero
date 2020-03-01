using System;

namespace BootCamp.Chapter.Combat.Attacks
{
    class Spit : IAttack
    {
        Random _random = new Random();

        public float GetDamage()
        {
            var power = (float)_random.NextDouble();
            return 50 * power;
        }

        public float GetRange()
        {
            var power = (float)_random.NextDouble();
            return 20 * power;
        }
    }
}