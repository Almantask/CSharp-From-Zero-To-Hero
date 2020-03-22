namespace BootCamp.Chapter.Items

{
    public class Armpiece : Armour

    {
        public float Defense { get; set; }

        public Armpiece(string name, decimal price, float weight, float defence) : base(name, price, weight, defence)

        {
            Defense = defence;
        }
    }
}