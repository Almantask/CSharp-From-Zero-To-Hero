using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        public MacFactory(string owningCompany) : base(owningCompany) { }

        protected override void PrepareBody(DesktopComputer computer)
        {

        }

        protected override void InstallMotherboard(DesktopComputer computer)
        {

        }

        protected override void InstallCpu(DesktopComputer computer)
        {

        }

        protected override void InstallGpu(DesktopComputer computer)
        {

        }

        protected override void InstallRam(DesktopComputer computer)
        {

        }

        protected override void InstallHardDisk(DesktopComputer computer)
        {

        }
    }
}
