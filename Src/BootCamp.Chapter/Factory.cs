using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract void InstallBody(DesktopComputer computer);
        
        public abstract void InstallRam(DesktopComputer computer);
        
        public abstract void InstallCpu(DesktopComputer computer);
        
        public abstract void InstallGpu(DesktopComputer computer);
        
        public abstract void InstallHard(DesktopComputer computer);
        
        public abstract void InstallMotherboard(DesktopComputer computer);
    }
}