namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public float Weight { get; private set; }

        public Item(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}