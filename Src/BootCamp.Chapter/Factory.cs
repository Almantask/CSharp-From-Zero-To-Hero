using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract string Brand();
        public DesktopComputer Assemble()
        {
            DesktopComputer PC = new DesktopComputer();
            PC.Body = InstallBody();
            PC.components.Add(PC.Body);
            PC.Cpu = InstallCpu();
            PC.components.Add(PC.Cpu);
            PC.Gpu = InstallGpu();
            PC.components.Add(PC.Gpu);
            PC.HardDisk = InstallHardDisk();
            PC.components.Add(PC.HardDisk);
            PC.Motherboard = InstallMotherboard();
            PC.components.Add(PC.Motherboard);
            PC.Ram = InstallRam();
            PC.components.Add(PC.Ram);


            Console.WriteLine($"Finished Building {Brand()}PC. Components List:");
            PC.PrintAssembledPc();
            return PC;
        }
        public abstract Body InstallBody();
        public abstract Cpu InstallCpu();
        public abstract Gpu InstallGpu();
        public abstract HardDisk InstallHardDisk();
        public abstract Motherboard InstallMotherboard();
        public abstract Ram InstallRam();
        public abstract void PrintAddMsg(string component);
    }
}
