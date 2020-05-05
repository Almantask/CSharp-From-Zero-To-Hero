namespace BootCamp.Chapter.Computer
{
    public class HardDisk : Component
    {
        private int _rpm;
        public int GetRPM()
        {
            return _rpm;
        }

        private int _capacity;
        public int GetCapacity()
        {
            return _capacity;
        }

        public HardDisk(string id, string manufacturer, string modelName, int rpm, int capacity) : base (id, manufacturer, modelName)
        {
            _rpm = rpm;
            _capacity = capacity;
        }
    }
}