namespace BootCamp.Chapter.Items
{
    public class Shoulderpiece : Item
    {
        public Shoulderpiece(string name, decimal price, float weight) : base(name, price, weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
