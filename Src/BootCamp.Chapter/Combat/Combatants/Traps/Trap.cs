using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Attacks;
using BootCamp.Chapter.Utilities;

namespace BootCamp.Chapter.Combat.Combatants.Traps
{
    public abstract class Trap : IAttacker
    {
        private readonly IAttack _attack;
        private readonly Point _position;

        public Trap(IAttack attack, Point position)
        {
            _attack = attack;
            _position = position;
        }

        public void Attack(IDefender defender)
        {
            var distance = Distance.Calculate(defender.GetPosition(), _position);
            if (distance < _attack.GetRange())
            {
                defender.DefendFrom(_attack);
            }
        }

        public Point GetPosition()
        {
            return _position;
        }
    }
}
