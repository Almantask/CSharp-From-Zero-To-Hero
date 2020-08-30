using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory
    {

        public DesktopComputer Assemble()
        {
            DesktopComputer desktopComputer = new DesktopComputer(new Body(), new Ram(), new Cpu(), new Gpu(), new HardDisk(), new Motherboard());

            desktopComputer.GetBody();
            desktopComputer.GetCpu();
            desktopComputer.GetGpu();
            desktopComputer.GetHard();
            desktopComputer.GetRam();
            desktopComputer.GetMotherboard();

            return desktopComputer;
        }
       
    }
}
