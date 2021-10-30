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
            DesktopComputer mac = new DesktopComputer();

            mac.GetBody();
            mac.GetCpu();
            mac.GetRam();
            mac.GetGpu();
            mac.GetHard();
            mac.GetMotherboard();

            return mac;
            //return new DesktopComputer();
        }
    }
}
