using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants.Destructibles
{
    class Wall : IDefender
    {
        public float GetHitPoints()
        {
            throw new NotImplementedException();
        }

        public void DefendFrom(IAttack attack)
        {
            throw new NotImplementedException();
        }

        public Point GetPosition()
        {
            throw new NotImplementedException();
        }
    }
}
