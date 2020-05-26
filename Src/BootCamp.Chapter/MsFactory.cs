using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : PcFactory
    {
        private Body _msBody;
        private Cpu _msCpu;
        private Gpu _msGpu;
        private HardDisk _msHardDisk;
        private Motherboard _msMotherboard;
        private Ram _msRam;

        public override void AssembleBody()
        {
            _msBody = new Body();
            base.body = _msBody;
        }

        public override void AssembleCpu()
        {
            _msCpu = new Cpu();
            base.cpu = _msCpu;
        }

        public override void AssembleGpu()
        {
            _msGpu = new Gpu();
            base.gpu = _msGpu;
        }

        public override void AssembleHardDisk()
        {
            _msHardDisk = new HardDisk();
            base.disk = _msHardDisk;
        }

        public override void AssembleMotherboard()
        {
            _msMotherboard = new Motherboard();
            base.board = _msMotherboard;
        }

        public override void AssembleRam()
        {
            _msRam = new Ram();
            base.ram = _msRam;
        }
    }
}
