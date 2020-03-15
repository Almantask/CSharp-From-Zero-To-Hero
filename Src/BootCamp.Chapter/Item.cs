namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; private set; }

        public decimal Price { get; private set; }

        private float _weight;

        public Item(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            _weight = weight;
        }
    }
}