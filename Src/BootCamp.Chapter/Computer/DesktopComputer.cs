namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        public DesktopComputer()
        {
            _body = new Body();
            _ram = new Ram();
            _cpu = new Cpu();
            _gpu = new Gpu();
            _hard = new HardDisk();
            _motherboard = new Motherboard();
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

        public virtual string CompletedAssembly()
        {
            return "Assembly of computer complete.";
        }
    }
}
