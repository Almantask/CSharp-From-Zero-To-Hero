using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : PcFactory
    {
        public override Body PrepareBody()
        {
            Body msBody = new Body();
            return msBody;
        }

        public override Cpu PrepareCpu()
        {
            Cpu msCpu = new Cpu();
            return msCpu;
        }

        public override Gpu PrepareGpu()
        {
            Gpu msGpu = new Gpu();
            return msGpu;
        }

        public override HardDisk PrepareHardDisk()
        {
            HardDisk msHardDisk = new HardDisk();
            return msHardDisk;
        }

        public override Motherboard PrepareMotherboard()
        {
            Motherboard msMotherboard = new Motherboard();
            return msMotherboard;
        }

        public override Ram PrepareRam()
        {
            Ram msRam = new Ram();
            return msRam;
        }
    }
}
