using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants.Traps
{
    class SpitTrap : Trap
    {
        public SpitTrap(Point position) : base(new Spit(), position)
        {
        }
    }
}
