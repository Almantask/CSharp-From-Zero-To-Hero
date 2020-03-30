using System;

namespace BootCamp.Chapter
{
    class Monster
    {
        public event EventHandler OnDead;
        public event EventHandler<OnMonsterHitEventArgs> OnMonsterHit;

        public string Name { get; }
        public bool IsAlive => _hp > 0;

        private int _hp;
        private readonly Random _random = new Random();

        public Monster(string name)
        {
            Name = name;
            _hp = 100;
        }

        public void Attack(Monster monster)
        {
            // min/max power.
            if (IsAlive)
            {
                var power = _random.Next(5, 20);
                monster.TakeDamage(power);
            }
        } 

        private void TakeDamage(int damage)
        {
            if(!IsAlive) return;
            _hp -= damage;
            OnMonsterHit?.Invoke(this, new OnMonsterHitEventArgs(damage));
            if (!IsAlive)
            {
                OnDead?.Invoke(this, null);
            }
        }
    }
}
