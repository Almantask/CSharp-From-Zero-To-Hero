namespace BootCamp.Chapter.Items
{
    public class Armour : Item
    {
        private float _baseDefense;

        public float GetBaseDefense()
        {
            return _baseDefense;
        }

        public Armour(string name, decimal price, float weight, float baseDefense) : base(name, price, weight)
        {
            _baseDefense = baseDefense;
        }
    }
}