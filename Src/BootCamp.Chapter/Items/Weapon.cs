namespace BootCamp.Chapter.Items
{
    public class Weapon : Item
    {
        public Weapon(string name, decimal price, float weight) : base(name, price, weight)
        {
            Name = name;
            Price = price;
            Weight = weight;
        }
    }
}
