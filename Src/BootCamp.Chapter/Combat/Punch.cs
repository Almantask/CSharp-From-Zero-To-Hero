namespace BootCamp.Chapter.Combat
{
    class Punch : IAttack
    {
        public float GetDamage()
        {
            return 60;
        }

        public float GetRange()
        {
            return 0;
        }
    }
}