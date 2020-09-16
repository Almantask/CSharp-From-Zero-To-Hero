namespace BootCamp.Chapter
{
    public class Item
    {
        protected string _name;
        public string GetName()
        {
            return _name;
        }

        protected decimal _price;
        public decimal GetPrice()
        {
            return _price;
        }

        protected float _weight;
        public float GetWeight()
        {
            return _weight;
        }

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}