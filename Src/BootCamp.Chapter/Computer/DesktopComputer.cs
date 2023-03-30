namespace BootCamp.Chapter.Computer
{
    public class DesktopComputer
    {
        private Body _body;
        public Body GetBody()
        {
            return _body;
        }

        public void SetBody(string body)
        {
            _body = new Body(body);
        }
        
        private Ram _ram;
        public Ram GetRam()
        {
            return _ram;
        }

        public void SetRam(string ram)
        {
            _ram = new Ram(ram);
        }

        private Cpu _cpu;
        public Cpu GetCpu()
        {
            return _cpu;
        }

        public void SetCpu(string cpu)
        {
            _cpu = new Cpu(cpu);
        }
        
        
        private Gpu _gpu;
        public Gpu GetGpu()
        {
            return _gpu;
        }

        public void SetGpu(string gpu)
        {
            _gpu = new Gpu(gpu);
        }

        private HardDisk _hard;
        public HardDisk GetHard()
        {
            return _hard;
        }

        public void SetHard(string hard)
        {
            _hard = new HardDisk(hard);
        }

        private Motherboard _motherboard;
        public Motherboard GetMotherboard()
        {
            return _motherboard;
        }

        public void SetMotherboard(string motherboard)
        {
            _motherboard = new Motherboard(motherboard);
        }
    }
}
