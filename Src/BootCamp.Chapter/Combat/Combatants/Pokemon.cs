using System;
using System.Drawing;
using BootCamp.Chapter.Combat.Attacks;
using BootCamp.Chapter.Utilities;

namespace BootCamp.Chapter.Combat.Combatants
{
    class Pokemon : ICombatant
    {
        private readonly Random _random;

        private float _hitPoints;
        public float GetHitPoints()
        {
            return _hitPoints;
        }

        private Point _position;
        public Point GetPosition()
        {
            return _position;
        }

        private readonly IAttack[] _attacks;

        public Pokemon(float hitPoints, IAttack[] attacks, Point position)
        {
            if (attacks.Length == 0)
            {
                throw new Exception("Attacker needs to be able to attack.");
            }

            _hitPoints = hitPoints;
            _attacks = attacks;
            _random = new Random();
            _position = position;
        }

        public virtual void DefendFrom(IAttack attack)
        {
            _hitPoints -= attack.GetDamage();
        }

        public virtual void Attack(IDefender defender)
        {
            var randomAttackIndex = _random.Next(0, _attacks.Length);
            var attack = _attacks[randomAttackIndex];

            var distance = Distance.Calculate(_position, defender.GetPosition());
            if (attack.GetRange() > distance)
            {
                defender.DefendFrom(attack);
            }
        }
    }
}