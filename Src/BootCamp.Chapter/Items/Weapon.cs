namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        public float BaseAttack { get; }
        
        public Weapon(string name, decimal price, float weight, float baseAttack) : base(name, price, weight)
        {
            BaseAttack = baseAttack;
        }
    }
}
