namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private string _name;
        private decimal _price;
        private float _weight;

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
