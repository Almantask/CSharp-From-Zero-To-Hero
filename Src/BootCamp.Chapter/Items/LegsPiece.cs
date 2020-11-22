namespace BootCamp.Chapter.Items
{
    public class Legspiece
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Legspiece(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
        public float GetWeight()
        {
            return _weight;
        }
        private float _defense;
        public float GetDefense()
        {
            return _defense;
        }
    }
}
