namespace BootCamp.Chapter
{
    public class Armour : Item
    {
        public float Defence { get; set; }

        public Armour(string name, decimal price, float weight, float defence) : base(name, price, weight)
        {
            Defence = defence;
        }
    }
}