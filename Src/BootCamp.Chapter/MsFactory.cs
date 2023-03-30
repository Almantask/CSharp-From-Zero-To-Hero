using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        private readonly DesktopComputer _computer = new DesktopComputer();
        
        public DesktopComputer Assemble()
        {
            _computer.SetBody("Win Body");
            _computer.SetCpu("Win CPU");
            _computer.SetGpu("Win GPU");
            _computer.SetHard("Win Hard-Disk");
            _computer.SetMotherboard("Win Motherboard");
            _computer.SetRam("Win RAM");
            return _computer;
        }
    }
}
