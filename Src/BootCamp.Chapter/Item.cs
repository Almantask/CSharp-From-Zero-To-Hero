namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }

        public Item(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}