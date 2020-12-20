namespace BootCamp.Chapter.Items
{
    public class Headpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Headpiece(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
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

        private float _defense;
        public float Defense
        {
            get => _defense;
            set => _defense = value;
        }
    }
}
