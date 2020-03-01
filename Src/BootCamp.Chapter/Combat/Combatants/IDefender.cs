using System.Drawing;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants
{
    interface IDefender
    {
        float GetHitPoints();
        void DefendFrom(IAttack attack);
        Point GetPosition();
    }
}