namespace BootCamp.Chapter.Computer
{
    public class Motherboard : Component
    {
        private string _chipset;

        public string GetChipset()
        {
            return _chipset;
        }

        private string _chipsetManufacturer;

        public string GetChipsetManufacturer()
        {
            return _chipsetManufacturer;
        }

        private string _socket;

        public string GetSocket()
        {
            return _socket;
        }

        public Motherboard(string id, string manufacturer, string modelName, string chipset, string chipsetManufacturer, string socket) : base (id, manufacturer, modelName)
        {
            _chipset = chipset;
            _chipsetManufacturer = chipset;
            _socket = socket;
        }
    }
}