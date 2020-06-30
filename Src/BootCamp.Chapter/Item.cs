namespace BootCamp.Chapter
{
    public class Item
    {
        protected string _name;
        public string Name { get { return _name;} }
        protected decimal _price;
        public decimal Price { get { return _price;} }

        protected float _weight;
        public float Weight { get { return _weight; } }

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
    }
}