namespace BootCamp.Chapter.Items
{
    public class Legspiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Legspiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetLegspieceDefence()
        {
            return this._defense;
        }
        public float GetLegspieceWeightStat()
        {
            return this._weight;
        }
    }
}
