namespace BootCamp.Chapter.Computer
{
    public class ComputerCase
    {
        readonly string _manufacturersId;
        public ComputerCase(string manufacturersId)
        {
            _manufacturersId = manufacturersId;
        }

        public string GetManufacturersId()
        {
            return _manufacturersId;
        }
    }
}
