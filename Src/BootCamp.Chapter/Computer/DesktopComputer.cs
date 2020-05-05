namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        private Body _body;
        public Body GetBody()
        {
            return _body;
        }

        public void SetBody(Body body)
        {
            _body = body;
        } 
        
        private Ram _ram;

        public Ram GetRam()
        {
            return _ram;
        }

        public void SetRam(Ram ram)
        {
            _ram = ram;
        }

        private Cpu _cpu;
        public Cpu GetCpu()
        {
            return _cpu;

        }

        public void SetCpu(Cpu cpu)
        {
            _cpu = cpu;
        }

        private Gpu _gpu;
        public Gpu GetGpu()
        {
            return _gpu;
        }

        public void SetGpu(Gpu gpu)
        {
            _gpu = gpu;
        }

        private HardDisk _hard;
        public HardDisk GetHardDisk()
        {
            return _hard;
        }

        public void SetHardDisk(HardDisk hardDisk)
        {
            _hard = hardDisk;
        }

        private Motherboard _motherboard;
        public Motherboard GetMotherboard()
        {
            return _motherboard;
        }

        public void SetMotherboard(Motherboard motherboard)
        {
            _motherboard = motherboard;
        }
    }
}
