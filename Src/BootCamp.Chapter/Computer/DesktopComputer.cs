namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        public DesktopComputer()
        {
            _body = new Body();
            _cpu = new Cpu();
            _gpu = new Gpu();
            _hard = new HardDisk();
            _motherboard = new Motherboard();
            _ram = new Ram();
        }
        private Body _body;
        public Body GetBody()
        {
            return _body;
        }

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
