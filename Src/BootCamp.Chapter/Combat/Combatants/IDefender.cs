using System;
using System.Drawing;
using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Combatants
{
    public interface IDefender
    {
        float GetHitPoints();
        void DefendFrom(IAttack attack);
        Point GetPosition();
    }

    public interface IMovable
    {
        void Move(Point position);
    }

}