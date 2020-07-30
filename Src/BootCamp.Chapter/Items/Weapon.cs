namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private float _attack;
        public float GetAttack()
        {
            return _attack;
        }

        public Weapon(string name, decimal price, float weight, float attack) : base(name, price, weight)
        {
            _attack = attack;
        }
    }
}
