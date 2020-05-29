namespace BootCamp.Chapter.Items
{
    public class Headpiece : Armor
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Headpiece(string name, decimal price, float weight, float defenseValue) : base(name, price, weight, defenseValue)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
