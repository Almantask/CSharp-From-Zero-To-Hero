namespace BootCamp.Chapter
{
    public class Item
    {
        private string _name;

        public static int totalItemCount = 0;
        public string GetName()
        {
            return _name;
        }

        private decimal _price;
        public decimal GetPrice()
        {
            return _price;
        }

        private float _weight;
        public float GetWeight()
        {
            return _weight;
        }

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;

            totalItemCount++;
        }
    }
}