using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        private string _owningCompany;
        public string GetOwningCompany()
        {
            return _owningCompany;
        }

        protected Factory(string owningCompany)
        {
            _owningCompany = owningCompany;
        }

        protected DesktopComputer Assemble()
        {
            DesktopComputer computer = new DesktopComputer();
            PrepareBody(computer);
            InstallMotherboard(computer);
            InstallCpu(computer);
            InstallRam(computer);
            InstallHardDisk(computer);

            return computer;
        }

        protected abstract void PrepareBody(DesktopComputer computer);
        protected abstract void InstallMotherboard(DesktopComputer computer);
        protected abstract void InstallCpu(DesktopComputer computer);
        protected abstract void InstallGpu(DesktopComputer computer);
        protected abstract void InstallRam(DesktopComputer computer);
        protected abstract void InstallHardDisk(DesktopComputer computer);
    }
}
