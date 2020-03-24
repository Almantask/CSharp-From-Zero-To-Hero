﻿using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        public abstract void InstallBody(DesktopComputer computer);
        public abstract void InstallMotherboard(DesktopComputer computer);
        public abstract void InstallCpu(DesktopComputer computer);
        public abstract void InstallGpu(DesktopComputer computer);
        public abstract void InstallRam(DesktopComputer computer);
        public abstract void InstallHardDisk(DesktopComputer computer);
        public abstract DesktopComputer Assemble();
    }
}
