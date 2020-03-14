using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        protected Body _body;
        protected Ram _ram;
        protected Cpu _cpu;
        protected Gpu _gpu;
        protected HardDisk _hard;
        protected Motherboard _motherboard;

        public abstract void InstallBody();
        public abstract void InstallRam();
        public abstract void InstallCpu();
        public abstract void InstallGpu();
        public abstract void InstallHardDisk();
        public abstract void InstallMotherboard();

        public abstract DesktopComputer Assemble();
    }
}
