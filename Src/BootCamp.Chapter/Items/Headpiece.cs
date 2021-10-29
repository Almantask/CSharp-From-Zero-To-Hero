namespace BootCamp.Chapter.Items
{
    public class Headpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Headpiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetHeadpieceDefence()
        {
            return this._defense;
        }
        public float GetHeadpieceWeightStat()
        {
            return this._weight;
        }
    }
}
