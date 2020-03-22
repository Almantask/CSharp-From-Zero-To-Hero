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
    }
}
