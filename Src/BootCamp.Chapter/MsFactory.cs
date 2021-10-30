using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public DesktopComputer Assemble()
        {
            MsComputer windowsPC = new MsComputer();

            windowsPC.GetBody();
            windowsPC.GetCpu();
            windowsPC.GetRam();
            windowsPC.GetGpu();
            windowsPC.GetHard();
            windowsPC.GetMotherboard();

            return windowsPC;
            //return new DesktopComputer();
        }
    }
}
