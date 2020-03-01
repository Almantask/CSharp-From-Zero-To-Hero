using System.Drawing;

namespace BootCamp.Chapter.Combat
{
    interface IAttacker
    {
        void Attack(IDefender defender);
        Point GetPosition();
    }
}