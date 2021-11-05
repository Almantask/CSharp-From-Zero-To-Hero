namespace BootCamp.Chapter.Items
{
    public class Gloves
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Gloves(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetGlovesDefence()
        { 
            return this._defense;
        }
        public float GetGlovesWeightStat()
        {
            return this._weight;
        }
    }
}
