namespace BootCamp.Chapter.Items
{
    public class Armpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Armpiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetArmpieceDefence()
        {
            return this._defense;
        }
        public float GetArmpieceWeightStat()
        {
            return this._weight;
        }
    }
}
