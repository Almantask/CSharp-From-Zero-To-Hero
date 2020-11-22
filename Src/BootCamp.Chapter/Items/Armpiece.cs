namespace BootCamp.Chapter.Items
{
    public class Armpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Armpiece(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
        public float GetWeight()
        {
            return _weight;
        }
    }
}
