namespace BootCamp.Chapter.Computer
{
    public class Ram : Component
    {
        private RamType _ramType;

        public RamType GetRamType()
        {
            return _ramType;
        }

        private int _frequency;

        public int GetFrequency()
        {
            return _frequency;
        }

        private string _casLatency;

        public string GetCasLatency()
        {
            return _casLatency;
        }

        public Ram(string id, string manufacturer, string modelName, RamType ramType, int frequency, string casLatency) : base (id, manufacturer, modelName)
        {
            _ramType = ramType;
            _frequency = frequency;
            _casLatency = casLatency;
        }
    }

    public enum RamType
    {
        DDR,
        DDR2,
        DDR3,
        DDR4
    }
}