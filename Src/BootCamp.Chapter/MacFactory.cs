using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : PcFactory
    {
        private Body _macBody;
        private Cpu _macCpu;
        private Gpu _macGpu;
        private HardDisk _macHardDisk;
        private Motherboard _macMotherboard;
        private Ram _macRam;

        public override void AssembleBody()
        {
            _macBody = new Body();
            base.body = _macBody;
        }

        public override void AssembleCpu()
        {
            _macCpu = new Cpu();
            base.cpu = _macCpu;
        }

        public override void AssembleGpu()
        {
            _macGpu = new Gpu();
            base.gpu = _macGpu;
        }

        public override void AssembleHardDisk()
        {
            _macHardDisk = new HardDisk();
            base.disk = _macHardDisk;
        }

        public override void AssembleMotherboard()
        {
            _macMotherboard = new Motherboard();
            base.board = _macMotherboard;
        }

        public override void AssembleRam()
        {
            _macRam = new Ram();
            base.ram = _macRam;
        }
    }
}
