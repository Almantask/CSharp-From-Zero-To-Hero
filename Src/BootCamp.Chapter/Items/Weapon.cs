namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        public float AttackValue { get; private set; }

        public Weapon(string name, decimal price, float weight, float attackValue) : base(name, price, weight)
        {
            AttackValue = attackValue;
        }
    }
}