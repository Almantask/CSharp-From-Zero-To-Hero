namespace BootCamp.Chapter.Items
{
    public class Weapon
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public float Weight { get; set; }
        public int Attack { get; set; }
        
        public Weapon(string name, decimal price, float weight, int attack)
        {
            Name = name;
            Price = price;
            Weight = weight;
            Attack = attack;
        }
    }
}
