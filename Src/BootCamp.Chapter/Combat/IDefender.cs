using System.Drawing;

namespace BootCamp.Chapter.Combat
{
    interface IDefender
    {
        float GetHitPoints();
        void DefendFrom(IAttack attack);
        Point GetPosition();
    }
}