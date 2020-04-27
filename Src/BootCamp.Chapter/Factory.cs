using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();

            InstallBody(computer);
            InstallRam(computer);
            InstallCpu(computer);
            InstallGpu(computer);
            InstallHard(computer);
            InstallMotherboard(computer);
            
            return computer;
        }
        
        public abstract void InstallBody(DesktopComputer computer);
        public abstract void InstallRam(DesktopComputer computer);
        public abstract void InstallCpu(DesktopComputer computer);
        public abstract void InstallGpu(DesktopComputer computer);
        public abstract void InstallHard(DesktopComputer computer);
        public abstract void InstallMotherboard(DesktopComputer computer);
        public abstract void PrintAssemblingStatus(Component computer);
    }
}