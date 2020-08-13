namespace BootCamp.Chapter
{
    public class Item
    {
        private string _name;
        private decimal _price;
        private float _weight;

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;
        }
       
        public string GetName()
        {
            return _name;
        }

      
        public decimal GetPrice()
        {
            return _price;
        }
    }
}