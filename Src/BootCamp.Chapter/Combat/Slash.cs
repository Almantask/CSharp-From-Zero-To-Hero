namespace BootCamp.Chapter.Combat
{
    class Slash : IAttack
    {
        public float GetDamage()
        {
            return 20;
        }

        public float GetRange()
        {
            return 2;
        }
    }
}