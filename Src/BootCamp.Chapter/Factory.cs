using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        protected Factory() { }

        public DesktopComputer Assemble()
        {
            DesktopComputer computer = new DesktopComputer();
            PrepareBody(computer);
            InstallMotherboard(computer);
            InstallCpu(computer);
            InstallGpu(computer);
            InstallRam(computer);
            InstallHardDisk(computer);
            TagManufacturer(computer);

            return computer;
        }

        protected abstract void PrepareBody(DesktopComputer computer);
        protected abstract void InstallMotherboard(DesktopComputer computer);
        protected abstract void InstallCpu(DesktopComputer computer);
        protected abstract void InstallGpu(DesktopComputer computer);
        protected abstract void InstallRam(DesktopComputer computer);
        protected abstract void InstallHardDisk(DesktopComputer computer);
        protected abstract void TagManufacturer(DesktopComputer computer);
    }
}
