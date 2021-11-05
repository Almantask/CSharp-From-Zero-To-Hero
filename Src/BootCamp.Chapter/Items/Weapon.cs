namespace BootCamp.Chapter.Items
{
    public class Weapon
    {
        private string _name;
        private decimal _price;
        private float _weight;
        private float _attack;

        public Weapon(string name, decimal price, float weight, float attack)
        {
            _name = name;
            _price = price;
            _weight = weight;
            _attack = attack;
        }

        public float GetWeaponAttackStat()
        {
            return this._attack;
        }

        public float GetWeaponWeightStat()
        {
            return this._weight;
        }
    }
}
