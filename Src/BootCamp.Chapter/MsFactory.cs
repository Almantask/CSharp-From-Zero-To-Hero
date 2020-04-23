using System;
using System.Threading;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        public DesktopComputer Assemble()
        {
            var pc = new DesktopComputer();

            InstallBody(pc);
            InstallRam(pc);
            InstallCpu(pc);
            InstallGpu(pc);
            InstallHard(pc);
            InstallMotherboard(pc);
            
            return pc;
        }

        public override void InstallBody(DesktopComputer pc)
        {
            var pcBody = new Body(87, "Generic Case");
            pc.SetBody(pcBody);
            PrintAssemblingStatus(pc.GetBody());
        }

        public override void InstallRam(DesktopComputer pc)
        {
            var pcRam = new Ram(20, "HyperX Fury DDR4 2666mhz");
            pc.SetRam(pcRam);
            PrintAssemblingStatus(pc.GetRam());
        }

        public override void InstallCpu(DesktopComputer pc)
        {
            var pcCpu = new Cpu(1, "AMD Ryzen 5 2600");
            pc.SetCpu(pcCpu);
            PrintAssemblingStatus(pc.GetCpu());
        }
        public override void InstallGpu(DesktopComputer pc)
        {
            var pcGpu = new Gpu(32, "Nvidia GTX 1080");
            pc.SetGpu(pcGpu);
            PrintAssemblingStatus(pc.GetGpu());
        }

        public override void InstallHard(DesktopComputer pc)
        {
            var pcHard = new HardDisk(6, "SSD Kingston A400 240GB");
            pc.SetHard(pcHard);
            PrintAssemblingStatus(pc.GetHard());
        }

        public override void InstallMotherboard(DesktopComputer pc)
        {
            var pcMotherboard = new Motherboard(54, "Gigabyte B450M DS3H");
            pc.SetMotherboard(pcMotherboard);
            PrintAssemblingStatus(pc.GetMotherboard());
        }
        
        private void PrintAssemblingStatus(Component component)
        {
            Console.WriteLine($"Assembling: [ID = {component.GetId()}] [NAME = {component.GetName()}]");
            Thread.Sleep(200);
        }
    }
}
