namespace BootCamp.Chapter.Items
{
    public class Gloves
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

        private float _defense;
        public float Defense
        {
            get => _defense;
        }

        public Gloves(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }
    }
}
