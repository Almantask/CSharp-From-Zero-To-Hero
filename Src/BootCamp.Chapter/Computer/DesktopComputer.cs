namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        private Ram _ram;
        public Ram GetRam()
        {
            return _ram;
        }

        private Cpu _cpu;
        public Cpu GetCpu()
        {
            return _cpu;

        }
        private Gpu _gpu;
        public Gpu GetGpu()
        {
            return _gpu;
        }

        private HardDisk _hard;
        public HardDisk GetHard()
        {
            return _hard;
        }

        private Motherboard _motherboard;
        public Motherboard GetMotherboard()
        {
            return _motherboard;
        }
    }
}
