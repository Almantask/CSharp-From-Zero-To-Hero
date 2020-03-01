using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Weapons
{
    class Sword : IWeapon
    {
        public IAttack GetAttack()
        {
            return new Slash();
        }
    }
}