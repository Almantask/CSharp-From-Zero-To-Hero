namespace BootCamp.Chapter.Items
{
    public class Headpiece : Item
    {
        public Headpiece(string name, decimal price, float weight) : base(name, price, weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
