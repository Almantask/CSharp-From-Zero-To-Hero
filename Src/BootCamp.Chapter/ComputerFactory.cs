using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class ComputerFactory
    {
        public virtual DesktopComputer Assemble()
        {
            return new DesktopComputer(new Body(), new Ram(), new Cpu(), new Gpu(), new HardDisk(), new Motherboard());
        }   
    }
}
