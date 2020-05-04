namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private float _attackValue;
        
        public float GetAttackValue()
        {
            return _attackValue;
        }

        public Weapon(string name, decimal price, float weight, float attackValue) : base(name, price, weight)
        {
            _attackValue = attackValue;
        }
    }
}
