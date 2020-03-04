namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        private Body _body;
        public Body GetBody()
        {
            return _body;
        }
        public void SetBody(string manufacturersId)
        {
            _body = new Body(manufacturersId);
        }

        private Ram _ram;
        public Ram GetRam()
        {
            return _ram;
        }
        public void SetRam()
        {
            _ram = new Ram();
        }

        private Cpu _cpu;
        public Cpu GetCpu()
        {
            return _cpu;
        }
        public void SetCpu()
        {
            _cpu = new Cpu();
        }

        private Gpu _gpu;
        public Gpu GetGpu()
        {
            return _gpu;
        }
        public void SetGpu()
        {
            _gpu = new Gpu();
        }

        private HardDisk _hard;
        public HardDisk GetHard()
        {
            return _hard;
        }
        public void SetHard()
        {
            _hard = new HardDisk();
        }

        private Motherboard _motherboard;
        public Motherboard GetMotherboard()
        {
            return _motherboard;
        }
        public void SetMotherboard(string manufacturersId)
        {
            _motherboard = new Motherboard(manufacturersId);
        }
    }
}
