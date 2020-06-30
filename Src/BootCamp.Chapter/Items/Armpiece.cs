namespace BootCamp.Chapter.Items
{
    public class Armpiece : Item
    {
        public Armpiece(string name, decimal price, float weight) : base(name, price, weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
