namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private readonly float _damageValue;

        public float GetDamageValue()
        {
            return _damageValue;
        }

        public Weapon(string name, decimal price, float weight, float damageValue) : base(name, price, weight)
        {
            _damageValue = damageValue;
        }
    }
}
