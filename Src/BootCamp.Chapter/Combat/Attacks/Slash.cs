namespace BootCamp.Chapter.Combat.Attacks
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