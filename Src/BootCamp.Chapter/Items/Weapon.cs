namespace BootCamp.Chapter.Items
{
    public class Weapon
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private int _attack;

        public Weapon(string name, decimal price, float weight, int attack)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _attack = attack;
        }

        public float GetWeight()
        {
            return _weight;
        }

        public int GetAttack()
        {
            return _attack;
        }
    }
}
