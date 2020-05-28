using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : PcFactory
    {
        public override void PrepareBody()
        {
            Body macBody = new Body();
            base.body = macBody;
        }

        public override void PrepareCpu()
        {
            Cpu macCpu = new Cpu();
            base.cpu = macCpu;
        }

        public override void PrepareGpu()
        {
            Gpu macGpu = new Gpu();
            base.gpu = macGpu;
        }

        public override void PrepareHardDisk()
        {
            HardDisk macHardDisk = new HardDisk();
            base.disk = macHardDisk;
        }

        public override void PrepareMotherboard()
        {
            Motherboard macMotherboard = new Motherboard();
            base.board = macMotherboard;
        }

        public override void PrepareRam()
        {
            Ram macRam = new Ram();
            base.ram = macRam;
        }
    }
}
