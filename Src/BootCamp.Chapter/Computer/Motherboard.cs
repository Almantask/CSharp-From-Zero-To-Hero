namespace BootCamp.Chapter.Computer
{
    public class Motherboard
    {
        private string _manufacturersId;
        public Motherboard(string manufacturersId)
        {
            _manufacturersId = manufacturersId;
        }

        public string GetManufacturersId()
        {
            return _manufacturersId;
        }
    }
}