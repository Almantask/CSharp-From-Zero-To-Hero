namespace BootCamp.Chapter.Items
{
    public class Armpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Armpiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }
        public string Name
        {
            get =>  _name;
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

        private float _defense;
        public float Defense
        {
            get => _defense;
            set => _defense = value;
        }


    }
}
