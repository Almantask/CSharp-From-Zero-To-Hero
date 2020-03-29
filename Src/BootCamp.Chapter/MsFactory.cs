using BootCamp.Chapter.Computer;
using System;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        public override string Brand()
        {
            return "Ms";
        }
        public override void InstallBody(DesktopComputer PC)
        {
            PrintAddMsg("Body");
            PC.Body = new Body(Brand() + "Body");
        }
        public override void InstallCpu(DesktopComputer PC)
        {
            PrintAddMsg("Cpu");
            PC.Cpu = new Cpu(Brand() + "Cpu");
        }
        public override void InstallGpu(DesktopComputer PC)
        {
            PrintAddMsg("Gpu");
            PC.Gpu = new Gpu(Brand() + "Gpu");
        }
        public override void InstallHardDisk(DesktopComputer PC)
        {
            PrintAddMsg("HardDisk");
            PC.HardDisk = new HardDisk(Brand() + "HardDisk");
        }
        public override void InstallMotherboard(DesktopComputer PC)
        {
            PrintAddMsg("Motherboard");
            PC.Motherboard = new Motherboard(Brand() + "Motherboard");
        }
        public override void InstallRam(DesktopComputer PC)
        {
            PrintAddMsg("Ram");
            PC.Ram = new Ram(Brand() + "Ram");
        }
        public override void PrintAddMsg(string component)
        {
            Console.WriteLine($"Installing {component} to {Brand()}PC.");
        }
    }
}
