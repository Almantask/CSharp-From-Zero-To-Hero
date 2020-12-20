namespace BootCamp.Chapter
{
    public class Item
    {
        public string Name { get; }

        public decimal Price { get; }

        public float Weight { get; }
        public Item(string name, decimal price, float weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
        public static bool Equals(Item a, Item b)
        {
            if (a.Name == b.Name && a.Price == b.Price && a.Weight == b.Weight)
                return true;
            return false;
        }
    }
}