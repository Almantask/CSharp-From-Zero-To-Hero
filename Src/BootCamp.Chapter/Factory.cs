using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract string Brand();
        public DesktopComputer Assemble(string brand)
        {
            Console.WriteLine($"Building a {brand} PC.");
            DesktopComputer PC = new DesktopComputer();
            PC.Body = AddBody(brand);
            PC.components.Add(PC.Body);
            PC.Cpu = AddCpu(brand);
            PC.components.Add(PC.Cpu);
            PC.Gpu = AddGpu(brand);
            PC.components.Add(PC.Gpu);
            PC.HardDisk = AddHardDisk(brand);
            PC.components.Add(PC.HardDisk);
            PC.Motherboard = AddMotherboard(brand);
            PC.components.Add(PC.Motherboard);
            PC.Ram = AddRam(brand);
            PC.components.Add(PC.Ram);

            Console.WriteLine($"{brand}PC assembled!");
            PC.PrintAssembledPc();
            return PC;
        }
        public abstract Body InstallBody(string brand);
        public abstract Cpu InstallCpu(string brand);
        public abstract Gpu InstallGpu(string brand);
        public abstract HardDisk InstallHardDisk(string brand);
        public abstract Motherboard InstallMotherboard(string brand);
        public abstract Ram InstallRam(string brand);
        public abstract void PrintAddMsg(string component, string brand);
    }
}
