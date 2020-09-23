using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : DesktopComputer
    {
        Body msBody = new Body();
        Ram msRam = new Ram();
        Cpu msCpu = new Cpu();
        Gpu msGpu = new Gpu();
        HardDisk msHardDisk = new HardDisk();
        Motherboard msMotherBoard = new Motherboard();

        public DesktopComputer Assemble()
        {
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
