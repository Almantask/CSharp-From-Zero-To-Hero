using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : Factory
    {
        const string brand = "Ms";

        public override DesktopComputer Assemble()
        {
            Console.WriteLine($"Building a {brand} PC.");
            DesktopComputer MsPC = new DesktopComputer();
            MsPC.Body = AddBody(brand);
            MsPC.components.Add(MsPC.Body);
            MsPC.Cpu = AddCpu(brand);
            MsPC.components.Add(MsPC.Cpu);
            MsPC.Gpu = AddGpu(brand);
            MsPC.components.Add(MsPC.Gpu);
            MsPC.HardDisk = AddHardDisk(brand);
            MsPC.components.Add(MsPC.HardDisk);
            MsPC.Motherboard = AddMotherboard(brand);
            MsPC.components.Add(MsPC.Motherboard);
            MsPC.Ram = AddRam(brand);
            MsPC.components.Add(MsPC.Ram);

            Console.WriteLine($"{brand}PC assembled!");
            MsPC.PrintAssembledPc();
            return MsPC;
        }
    }
}
