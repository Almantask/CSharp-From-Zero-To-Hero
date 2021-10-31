using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory
    {
        public Body getWinBody { get; set; }
        public Cpu getWinCpu { get; set; }
        public Ram getWinRam { get; set; }
        public Gpu getWinGpu { get; set; }
        public HardDisk getWinHard { get; set; }
        public Motherboard getWinMotherboard { get; set; }
        public DesktopComputer Assemble()
        {
            MsComputer windowsPC = new MsComputer();

            getWinBody = windowsPC.GetBody();
            getWinCpu = windowsPC.GetCpu();
            getWinRam = windowsPC.GetRam();
            getWinGpu = windowsPC.GetGpu();
            getWinHard = windowsPC.GetHard();
            getWinMotherboard = windowsPC.GetMotherboard();

            return windowsPC;
            //return new DesktopComputer();
        }
    }
}
