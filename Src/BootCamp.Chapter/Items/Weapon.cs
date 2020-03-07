namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private float _damage;
        public float GetDamage()
        { 
            return _damage; 
        }

        public Weapon(string name, decimal price, float weight, float damage) : base(name, price, weight)
        {
            _damage = damage;
        }
    }
}
