namespace BootCamp.Chapter.Items
{
    public class Weapon
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Weapon(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
