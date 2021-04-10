namespace BootCamp.Chapter.Computer
{
    public abstract class DesktopComputer
    {

        public DesktopComputer(Body body, Ram ram, Cpu cpu, Gpu gpu, HardDisk hardDisk, Motherboard motherboard)
        {
            body = new Body();
            ram = new Ram();
            cpu = new Cpu();
            gpu = new Gpu();
            hardDisk = new HardDisk();
            motherboard = new Motherboard();
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
