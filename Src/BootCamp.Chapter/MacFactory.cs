using System;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Parts;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        public override void InstallBody(DesktopComputer mac)
        {
            var macBody = new Body(147, "Mac Body Pro™");
            mac.SetBody(macBody);
            PrintAssemblingStatus(mac.GetBody());
        }

        public override void InstallRam(DesktopComputer mac)
        {
            var macRam = new Ram(23, "Iram Pro");
            mac.SetRam(macRam);
            PrintAssemblingStatus(mac.GetRam());
        }

        public override void InstallCpu(DesktopComputer mac)
        {
            var macCpu = new Cpu(2, "Intel Core i7 8th Gen");
            mac.SetCpu(macCpu);
            PrintAssemblingStatus(mac.GetCpu());
        }
        public override void InstallGpu(DesktopComputer mac)
        {
            var macGpu = new Gpu(65, "Nvidia RTX 2070");
            mac.SetGpu(macGpu);
            PrintAssemblingStatus(mac.GetGpu());
        }

        public override void InstallHard(DesktopComputer mac)
        {
            var macHard = new HardDisk(25, "Apple SSD Pro™");
            mac.SetHard(macHard);
            PrintAssemblingStatus(mac.GetHard());
        }

        public override void InstallMotherboard(DesktopComputer mac)
        {
            var macMotherboard = new Motherboard(85, "Apple Motherboard v98");
            mac.SetMotherboard(macMotherboard);
            PrintAssemblingStatus(mac.GetMotherboard());
        }
        
        public override void PrintAssemblingStatus(Component component)
        {
            Console.WriteLine($"Assembling Premium: [ID = {component.GetId()}] [NAME = {component.GetName()}]");
        }
    }
}
