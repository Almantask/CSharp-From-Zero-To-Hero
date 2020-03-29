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
            InstallBody(PC);
            PC.components.Add(PC.Body);
            InstallCpu(PC);
            PC.components.Add(PC.Cpu);
            InstallGpu(PC);
            PC.components.Add(PC.Gpu);
            InstallHardDisk(PC);
            PC.components.Add(PC.HardDisk);
            InstallMotherboard(PC);
            PC.components.Add(PC.Motherboard);
            InstallRam(PC);
            PC.components.Add(PC.Ram);


            Console.WriteLine($"Finished Building {Brand()}PC. Components List:");
            PC.PrintAssembledPc();
            return PC;
        }
        public abstract void InstallBody(DesktopComputer PC);
        public abstract void InstallCpu(DesktopComputer PC);
        public abstract void InstallGpu(DesktopComputer PC);
        public abstract void InstallHardDisk(DesktopComputer PC);
        public abstract void InstallMotherboard(DesktopComputer PC);
        public abstract void InstallRam(DesktopComputer PC);
        public abstract void PrintAddMsg(string component);
    }
}
