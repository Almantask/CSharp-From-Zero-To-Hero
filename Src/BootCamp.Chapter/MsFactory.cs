using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : PcFactory
    {
        public override void PrepareBody()
        {
            Body msBody = new Body();
            base.body = msBody;
        }

        public override void PrepareCpu()
        {
            Cpu msCpu = new Cpu();
            base.cpu = msCpu;
        }

        public override void PrepareGpu()
        {
            Gpu msGpu = new Gpu();
            base.gpu = msGpu;
        }

        public override void PrepareHardDisk()
        {
            HardDisk msHardDisk = new HardDisk();
            base.disk = msHardDisk;
        }

        public override void PrepareMotherboard()
        {
            Motherboard msMotherboard = new Motherboard();
            base.board = msMotherboard;
        }

        public override void PrepareRam()
        {
            Ram msRam = new Ram();
            base.ram = msRam;
        }
    }
}
