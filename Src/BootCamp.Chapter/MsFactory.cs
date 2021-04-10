using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;


namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override DesktopComputer Assemble()
        {
            var computer = new DesktopComputer();
            PrepareBody(computer);
            InstallCpu(computer);
            InstallGpu(computer);
            InstallRam(computer);
            InstallHardDisk(computer);
            InstallMotherboard(computer);
            return computer;
        }
        public override void InstallCpu(DesktopComputer computer)
        {
            computer.SetCpu(new Cpu());
        }

        public override void InstallGpu(DesktopComputer computer)
        {
            computer.SetGpu(new Gpu());
        }

        public override void InstallHardDisk(DesktopComputer computer)
        {
            computer.SetHard(new HardDisk());
        }

        public override void InstallMotherboard(DesktopComputer computer)
        {
            computer.SetMotherBoard(new Motherboard());
        }

        public override void InstallRam(DesktopComputer computer)
        {
            computer.SetRam(new Ram());
        }

        public override void PrepareBody(DesktopComputer computer)
        {
            computer.SetBody(new Body());
        }
    }
}
