namespace BootCamp.Chapter.Items
{
    public class Shoulderpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Shoulderpiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetShoulderpieceDefence()
        {
            return this._defense;
        }
        public float GetShoulderpieceWeightStat()
        {
            return this._weight;
        }
    }
}
