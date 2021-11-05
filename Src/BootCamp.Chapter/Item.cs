using BootCamp.Chapter.Items;

namespace BootCamp.Chapter
{
    public class Item : IItem
    {
        private string _name;
        public string Name
        {
            get => _name;
        }

        private decimal _price;
        public decimal Price
        {
            get => _price;
        }

        private float _weight;
        public float Weight
        {
            get => _weight;
        }

        public static int totalItemCount = 0;

        public Item(string name, decimal price, float weight)
        {
            _name = name;
            _price = price;
            _weight = weight;

            totalItemCount++;
        }
    }
}