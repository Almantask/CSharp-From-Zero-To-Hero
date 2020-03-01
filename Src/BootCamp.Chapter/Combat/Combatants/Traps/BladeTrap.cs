using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants.Traps
{
    class BladeTrap : Trap
    {
        public BladeTrap(Point position) : base(new Slash(), position)
        {
        }
    }
}
