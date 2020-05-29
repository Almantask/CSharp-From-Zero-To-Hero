using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : PcFactory
    {
        public override Body PrepareBody()
        {
            Body macBody = new Body();
            return macBody;
        }

        public override Cpu PrepareCpu()
        {
            Cpu macCpu = new Cpu();
            return macCpu;
        }

        public override Gpu PrepareGpu()
        {
            Gpu macGpu = new Gpu();
            return macGpu;
        }

        public override HardDisk PrepareHardDisk()
        {
            HardDisk macHardDisk = new HardDisk();
            return macHardDisk;
        }

        public override Motherboard PrepareMotherboard()
        {
            Motherboard macMotherboard = new Motherboard();
            return macMotherboard;
        }

        public override Ram PrepareRam()
        {
            Ram macRam = new Ram();
            return macRam;
        }
    }
}
