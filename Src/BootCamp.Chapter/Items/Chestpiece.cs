namespace BootCamp.Chapter.Items
{
    public class Chestpiece : Armor
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Chestpiece(string name, decimal price, float weight, float defence) : base(name, price, weight, defence)
        {
        }
    }
}
