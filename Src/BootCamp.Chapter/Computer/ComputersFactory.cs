using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter.Computer
{
    public abstract class ComputersFactory
    {
        public abstract Body InstallBody();
        public abstract Cpu InstallCpu();
        public abstract Gpu InstallGpu();
        public abstract HardDisk InstallHardDisk();
        public abstract Ram InstallRam();
        public abstract Motherboard InstallMotherboard();


        public  DesktopComputer Assemble()
        {
            DesktopComputer desktopComputer = new DesktopComputer(InstallBody(), InstallRam(), InstallCpu(), InstallGpu(), InstallHardDisk(), InstallMotherboard()); ;

            return desktopComputer;
        }
    }
}
