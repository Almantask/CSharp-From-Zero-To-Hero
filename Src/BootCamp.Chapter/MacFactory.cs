using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;
using BootCamp.Chapter.Computer.Mac;

namespace BootCamp.Chapter
{
    public class MacFactory : ComputerFactory
    {
        public  override Body GetBody()
        {
            return new MacBody();
        }
        public override Ram GetRam()
        {
            return new MacRam();
        }
        public override Cpu GetCpu()
        {
            return new MacCpu();
        }
        public override Gpu GetGpu()
        {
            return new MacGpu();
        }
        public override HardDisk GetHardDisk()
        {
            return new MacHardDisk();
        }
        public override Motherboard GetMotherboard()
        {
            return new MacMotherboard();
        }
    }
}
