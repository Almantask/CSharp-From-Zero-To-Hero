using System.Drawing;
using BootCamp.Chapter.Combat.Armour;
using BootCamp.Chapter.Combat.Attacks;
using BootCamp.Chapter.Combat.Weapons;
using BootCamp.Chapter.Utilities;

namespace BootCamp.Chapter.Combat.Combatants
{
    class Human : ICombatant
    {
        private float _hitPoints;
        private readonly IWeapon _weapon;
        private readonly IArmour _armour;
        private Point _position;

        public float GetHitPoints()
        {
            return _hitPoints;
        }

        public Human(float hitPoints, IWeapon weapon, IArmour armour, Point position)
        {
            _hitPoints = hitPoints;
            _weapon = weapon;
            _armour = armour;
            _position = position;
        }

        public void DefendFrom(IAttack attack)
        {
            var negatedDamage = 1 - _armour.GetArmour();
            _hitPoints -= attack.GetDamage() * negatedDamage;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public void Attack(IDefender defender)
        {
            var attack = _weapon.GetAtack();

            var distance = Distance.Calculate(_position, defender.GetPosition());
            if (attack.GetRange() > distance)
            {
                defender.DefendFrom(attack);
            }
        }
    }
}