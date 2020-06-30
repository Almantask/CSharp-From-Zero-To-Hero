namespace BootCamp.Chapter.Items
{
    public class Chestpiece : Item
    {
        public Chestpiece(string name, decimal price, float weight) : base(name, price, weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
