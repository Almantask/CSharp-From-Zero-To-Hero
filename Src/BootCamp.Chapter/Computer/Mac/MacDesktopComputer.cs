
namespace BootCamp.Chapter.Computer.Mac
{
    public class MacDesktopComputer : DesktopComputer
    {
        public override void NeededComponents()
        {
            Body = new MacBody();
            Cpu = new MacCpu();
            Gpu = new MacGpu();
            HardDisk = new MacHardDisk();
            Motherboard = new MacMotherBoard();
            Ram = new MacRam();
        }
    }
}
