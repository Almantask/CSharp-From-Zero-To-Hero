namespace BootCamp.Chapter.Combat.Attacks
{
    class Punch : IAttack
    {
        public float GetDamage()
        {
            return 60;
        }

        public float GetRange()
        {
            return 3;
        }
    }
}