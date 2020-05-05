namespace BootCamp.Chapter.Computer
{
    public class Gpu : Component
    {
        private string _chipsetManufacturer;

        public string GetChipsetManufacturer()
        {
            return _chipsetManufacturer;
        }

        private string _memoryType;

        public string GetMemoryType()
        {
            return _memoryType;
        }

        private int _memorySize;

        public int GetMemorySize()
        {
            return _memorySize;
        }

        private int _memoryClock;

        public int GetMemoryClock()
        {
            return _memoryClock;
        }

        private int _gpuClock;

        public int GetGpuClock()
        {
            return _gpuClock;
        }


        public Gpu(string id, string manufacturer, string modelName, string chipsetManufacturer, string memoryType, int memorySize, int memoryClock, int gpuClock) : base (id, manufacturer, modelName)
        {
            _chipsetManufacturer = chipsetManufacturer;
            _memoryType = memoryType;
            _memorySize = memorySize;
            _memoryClock = memoryClock;
            _gpuClock = gpuClock;
        }
    }
}