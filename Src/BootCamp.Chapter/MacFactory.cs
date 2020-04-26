using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        public override DesktopComputer Assemble()
        {
            InstallBody(new Body(147, "Mac Body Pro"));
            InstallRam(new Ram(23, "Iram Pro"));
            InstallCpu(new Cpu(2, "Intel Core i7 8th Gen"));
            InstallGpu(new Gpu(65, "Nvidia RTX 2070"));
            InstallHard(new HardDisk(25, "Apple SSD Pro"));
            InstallMotherboard(new Motherboard(85, "Apple Motherboard v98"));
            
            var mac = GetComputer();
            return mac;
        }
    }
}
