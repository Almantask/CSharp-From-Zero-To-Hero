using System.Drawing;

namespace BootCamp.Chapter.Combat.Combatants
{
    interface IAttacker
    {
        void Attack(IDefender defender);
        Point GetPosition();
    }
}