namespace BootCamp.Chapter.Items
{
    public class Chestpiece
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _defense;

        public Chestpiece(string name, decimal price, float weight, float defense)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _defense = defense;
        }

        public float GetChestpieceDefence()
        {
            return this._defense;
        }

        public float GetChestpieceWeightStat()
        {
            return this._weight;
        }
    }
}
