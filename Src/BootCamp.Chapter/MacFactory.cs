using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
        public DesktopComputer Assemble()
        {
            Body macBody = new MacBody();
            Ram macRam = new MacRam();
            Cpu macCpu = new MacCpu();
            Gpu macGpu = new MacGpu();
            HardDisk macHardDisk = new MacHardDisk();
            Motherboard macMotherBoard = new MacMotherboard();

            DesktopComputer macComputer = new DesktopComputer();
            macComputer.SetBody(macBody);
            macComputer.SetRam(macRam);
            macComputer.SetCpu(macCpu);
            macComputer.SetGpu(macGpu);
            macComputer.SetHardDisk(macHardDisk);
            macComputer.SetMotherBoard(macMotherBoard);

            return macComputer;
        }
    }
}
