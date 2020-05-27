namespace BootCamp.Chapter.Items
{
    public class Chestpiece : Armor
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Chestpiece(string name, decimal price, float weight, float defenseValue) : base(name, price, weight, defenseValue)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}
