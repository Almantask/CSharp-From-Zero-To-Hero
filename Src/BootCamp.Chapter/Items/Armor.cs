namespace BootCamp.Chapter.Items
{
    public class Armor : Item
    {
        private readonly float _defenseValue;
        public float GetDefenseValue()
        {
            return _defenseValue;
        }
        public Armor(string name, decimal price, float weight, float defenseValue) : base(name, price, weight)
        {
            _defenseValue = defenseValue;
        }
    }
}
