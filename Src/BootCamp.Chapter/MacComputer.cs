using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class MacComputer : DesktopComputer
    {
        private MacBody _macBody;
        public override Body GetBody()
        {
            _macBody = new MacBody();
            return _macBody;
        }

        private MacCpu _macCpu;
        public override Cpu GetCpu()
        {
            _macCpu = new MacCpu();
            return _macCpu;
        }

        private MacGpu _macGpu;
        public override Gpu GetGpu()
        {
            _macGpu = new MacGpu();
            return _macGpu;
        }

        private MacHardDisk _macHard;
        public override HardDisk GetHard()
        {
            _macHard = new MacHardDisk();
            return _macHard;
        }

        private MacMotherBoard _macMotherBoard;
        public override Motherboard GetMotherboard()
        {
            _macMotherBoard = new MacMotherBoard();
            return _macMotherBoard;
        }

        private MacRam _macRam;
        public override Ram GetRam()
        {
            _macRam = new MacRam();
            return _macRam;
        }

        public override string ToString()
        {
            return string.Format("Mac PC");
        }
    }
}
