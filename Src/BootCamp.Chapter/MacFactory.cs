using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {
        private readonly DesktopComputer _computer = new DesktopComputer();
        
        public DesktopComputer Assemble()
        {
            _computer.SetBody("Mac Body");
            _computer.SetCpu("Mac CPU");
            _computer.SetGpu("Mac GPU");
            _computer.SetHard("Mac Hard-Disk");
            _computer.SetMotherboard("Mac Motherboard");
            _computer.SetRam("Mac RAM");
            return _computer;
        }
    }
}
