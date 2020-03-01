namespace BootCamp.Chapter.Combat
{
    class Sword : IWeapon
    {
        public IAttack GetAtack()
        {
            return new Slash();
        }
    }
}