using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;


namespace BootCamp.Chapter
{
    public class MacFactory
    {
        public DesktopComputer Assemble()
        {
            return new DesktopComputer();
        }
    }
}
