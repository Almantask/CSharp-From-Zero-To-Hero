using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants.Traps
{
    class PunchTrap: Trap
    {
        public PunchTrap(Point position) : base(new Punch(), position)
        {
        }
    }
}
