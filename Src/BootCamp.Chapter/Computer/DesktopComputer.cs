namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        private Body _body;
        public virtual Body GetBody()
        {
            return _body;
        }
        
        private Ram _ram;
        public virtual Ram GetRam()
        {
            return _ram;
        }

        private Cpu _cpu;
        public virtual Cpu GetCpu()
        {
            return _cpu;
        }
        private Gpu _gpu;
        public virtual Gpu GetGpu()
        {
            return _gpu;
        }

        private HardDisk _hard;
        public virtual HardDisk GetHard()
        {
            return _hard;
        }

        private Motherboard _motherboard;
        public virtual Motherboard GetMotherboard()
        {
            return _motherboard;
        }
    }
}
