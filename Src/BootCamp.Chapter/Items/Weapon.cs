namespace BootCamp.Chapter.Items
{
    public class Weapon
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Weapon(string name, decimal price, float weight,float attack)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _attack = attack;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public decimal Price
        {
            get => _price;
            set => _price = value;
        }
        public float Weight
        {
            get => _weight;
            set => _weight = value;
        }

        private float _attack;
        public float Attack
        {
            get => _attack;
            set => _attack = value;
        }
    }
}
