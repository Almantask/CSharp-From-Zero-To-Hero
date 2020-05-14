namespace BootCamp.Chapter.Objects
{
    public class CityByItems
    {
        public string City { get; }
        public int Count { get; }

        public CityByItems(string city, int count)
        {
            City = city;
            Count = count;
        }
    }
}