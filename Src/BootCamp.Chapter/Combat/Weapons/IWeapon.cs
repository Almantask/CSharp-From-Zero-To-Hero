using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Weapons
{
    internal interface IWeapon
    {
        IAttack GetAtack();
    }
}