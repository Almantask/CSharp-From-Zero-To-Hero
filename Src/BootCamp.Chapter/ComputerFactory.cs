using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        public abstract DesktopComputer Assemble();
        public abstract void CreateComputerCase();
        public abstract void InstallMotherboard();
        public abstract void InstallCpu();
        public abstract void InstallRam();
        public abstract void InstallGpu();
        public abstract void InstallHardDisk();

    }
}
