using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        public override DesktopComputer Assemble()
        {
            InstallBody(new Body(87, "Generic Case"));
            InstallRam(new Ram(20, "HyperX Fury DDR4 2666mhz"));
            InstallCpu(new Cpu(1, "AMD Ryzen 5 2600"));
            InstallGpu(new Gpu(32, "Nvidia GTX 1080"));
            InstallHard(new HardDisk(6, "SSD Kingston A400 240GB"));
            InstallMotherboard(new Motherboard(54, "Gigabyte B450M DS3H"));
            
            var pc = GetComputer();
            return pc;
        }

    }
}
