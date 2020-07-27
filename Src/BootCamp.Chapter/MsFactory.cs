using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Ms;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
    {
        public override Body GetBody()
        {
            return new MsBody();
        }
        public override Ram GetRam()
        {
            return new MsRam();
        }
        public override Cpu GetCpu()
        {
            return new MsCpu();
        }
        public override Gpu GetGpu()
        {
            return new MsGpu();
        }
        public override HardDisk GetHardDisk()
        {
            return new MsHardDisk();
        }
        public override Motherboard GetMotherboard()
        {
            return new MsMotherboard();
        }
    }
}
