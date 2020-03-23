using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        protected readonly Body _body;
        protected readonly Motherboard _motherboard;
        protected readonly Ram _ram;
        protected readonly Cpu _cpu;
        protected readonly Gpu _gpu;
        protected readonly HardDisk _hard;

        public ComputerFactory()
        {
            _body = new Body();
            _motherboard = new Motherboard();
            _cpu = new Cpu();
            _gpu = new Gpu();
            _ram = new Ram();
            _hard = new HardDisk();
        }

        public abstract void InstallBody(DesktopComputer computer);
        public abstract void InstallMotherboard(DesktopComputer computer);
        public abstract void InstallCpu(DesktopComputer computer);
        public abstract void InstallGpu(DesktopComputer computer);
        public abstract void InstallRam(DesktopComputer computer);
        public abstract void InstallHardDisk(DesktopComputer computer);
        public abstract DesktopComputer Assemble();
    }
}
