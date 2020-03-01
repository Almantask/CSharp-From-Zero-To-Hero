using BootCamp.Chapter.Combat.Attacks;

namespace BootCamp.Chapter.Combat.Weapons
{
    public interface IWeapon
    {
        IAttack GetAttack();
    }
}