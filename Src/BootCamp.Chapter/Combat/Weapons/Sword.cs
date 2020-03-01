using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Weapons
{
    class Sword : IWeapon
    {
        public IAttack GetAtack()
        {
            return new Slash();
        }
    }
}