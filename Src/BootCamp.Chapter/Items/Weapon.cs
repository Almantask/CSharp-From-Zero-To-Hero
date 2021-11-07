namespace BootCamp.Chapter.Items
{
    public class Weapon : IWeapon
    {
        private string _name;
        public string Name
        {
            get => _name;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
        }

        private float _weight;
        public float Weight
        {
            get => _weight;
        }

        private float _attack;
        public float Attack
        {
            get => _attack;
        }

        public Weapon(string name, decimal price, float weight, float attack)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _attack = attack;
        }
    }
}
