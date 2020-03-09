namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Weapon(string name, decimal price, float weight) : base(name, price, weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
