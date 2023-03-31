namespace BootCamp.Chapter.Items
{
    public class Headpiece
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public int Defense { get; set; }

        public Headpiece(string name, decimal price, float weight, int defense)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Defense = defense;
        }
    }
}
