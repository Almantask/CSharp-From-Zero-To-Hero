namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private float _baseAttack;

        public float GetBaseAttack()
        {
            return _baseAttack;
        }
        public Weapon(string name, decimal price, float weight, float baseAttack) : base(name, price, weight)
        {
            _baseAttack = baseAttack;
        }
    }
}
