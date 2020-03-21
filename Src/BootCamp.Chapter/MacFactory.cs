using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : Factory
    {
        const string brand = "Mac";

        public override DesktopComputer Assemble()
        {
            Console.WriteLine("Building a Mac PC.");
            DesktopComputer MacPC = new DesktopComputer();
            MacPC.Body = AddBody(brand);
            MacPC.components.Add(MacPC.Body);
            MacPC.Cpu = AddCpu(brand);
            MacPC.components.Add(MacPC.Cpu);
            MacPC.Gpu = AddGpu(brand);
            MacPC.components.Add(MacPC.Gpu);
            MacPC.HardDisk = AddHardDisk(brand);
            MacPC.components.Add(MacPC.HardDisk);
            MacPC.Motherboard = AddMotherboard(brand);
            MacPC.components.Add(MacPC.Motherboard);
            MacPC.Ram = AddRam(brand);
            MacPC.components.Add(MacPC.Ram);

            Console.WriteLine($"{brand}PC assembled!");
            MacPC.PrintAssembledPc();
            return MacPC;
        }
    }
}
