namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        public float Attack { get; }

        public Weapon(string name, decimal price, float weight, float attack) : base(name, price, weight)
        {
            Attack = attack;
        }
    }
}
