namespace BootCamp.Chapter.Items
{
    public class Armor : Item
    {
        public float Defence { get; set; }

        public Armor(string name, decimal price, float weight, float defence) : base(name, price, weight)
        {
            Defence = defence;
        }
    }
}