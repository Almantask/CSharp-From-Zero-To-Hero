using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Computer.Ms
{
    class MSDesktopComputer : DesktopComputer
    {
        public override void AssemblePC()
        {
            Body = new MsBody();
            Cpu = new MsCpu();
            Gpu = new MsGpu();
            HardDisk = new MsHardDisk();
            Motherboard = new MsMotherboard();
            Ram = new MsRam();
        }
    }
}
