using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public DesktopComputer Assemble()
        {
            Body msBody = new MsBody();
            Ram msRam = new MsRam();
            Cpu msCpu = new MsCpu();
            Gpu msGpu = new MsGpu();
            HardDisk msHardDisk = new MsHardDisk();
            Motherboard msMotherBoard = new MsMotherboard();

            DesktopComputer msComputer = new DesktopComputer();
            msComputer.SetBody(msBody);
            msComputer.SetRam(msRam);
            msComputer.SetCpu(msCpu);
            msComputer.SetGpu(msGpu);
            msComputer.SetHardDisk(msHardDisk);
            msComputer.SetMotherBoard(msMotherBoard);

            return msComputer;
        }
    }
}
