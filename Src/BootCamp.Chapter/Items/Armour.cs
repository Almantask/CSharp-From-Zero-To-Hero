namespace BootCamp.Chapter.Items
{
    public abstract class Armour : Item
    {
        public float BaseDefense { get; }
        
        protected Armour(string name, decimal price, float weight, float baseDefense) : base(name, price, weight)
        {
            BaseDefense = baseDefense;
        }
    }
}