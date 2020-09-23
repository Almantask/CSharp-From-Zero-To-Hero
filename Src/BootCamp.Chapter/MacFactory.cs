using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : DesktopComputer
    {
        Body macBody = new Body();
        Ram macRam = new Ram();
        Cpu macCpu = new Cpu();
        Gpu macGpu = new Gpu();
        HardDisk macHardDisk = new HardDisk();
        Motherboard macMotherBoard = new Motherboard();

        public DesktopComputer Assemble()
        {
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
