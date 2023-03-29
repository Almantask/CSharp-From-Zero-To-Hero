namespace BootCamp.Chapter.Items
{
    public class Headpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private int _defense;

        public Headpiece(string name, decimal price, float weight, int defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetWeight()
        {
            return _weight;
        }

        public int GetDefense()
        {
            return _defense;
        }
    }
}
