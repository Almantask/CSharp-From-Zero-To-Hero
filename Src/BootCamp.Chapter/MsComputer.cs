using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class MsComputer : DesktopComputer
    {
        private MsBody _msBody;
        public override Body GetBody()
        {
            _msBody = new MsBody();
            return _msBody;
        }

        private MsCpu _msCpu;
        public override Cpu GetCpu()
        {
            _msCpu = new MsCpu();
            return _msCpu;
        }

        private MsGpu _msGpu;
        public override Gpu GetGpu()
        {
            _msGpu = new MsGpu();
            return _msGpu;
        }

        private MsHardDisk _msHard;
        public override HardDisk GetHard()
        {
            _msHard = new MsHardDisk();
            return _msHard;
        }

        private MsMotherBoard _msMotherBoard;
        public override Motherboard GetMotherboard()
        {
            _msMotherBoard = new MsMotherBoard();
            return _msMotherBoard;
        }

        private MsRam _msRam;
        public override Ram GetRam()
        {
            _msRam = new MsRam();
            return _msRam;
        }

        public override string ToString()
        {
            return string.Format("Windows PC");
        }
    }
}
