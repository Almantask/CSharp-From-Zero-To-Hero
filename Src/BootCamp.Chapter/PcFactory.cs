using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class PcFactory
    {
        

        public DesktopComputer Assemble()
        {
            Body body = PrepareBody();
            Cpu cpu = PrepareCpu();
            Gpu gpu =PrepareGpu();
            HardDisk hardDisk = PrepareHardDisk();
            Motherboard motherboard = PrepareMotherboard();
            Ram ram = PrepareRam();

            return new DesktopComputer(body,cpu,gpu,hardDisk,motherboard,ram);
            
        }

        public abstract Body PrepareBody();
        public abstract Cpu PrepareCpu();
        public abstract Gpu PrepareGpu();
        public abstract HardDisk PrepareHardDisk();
        public abstract Motherboard PrepareMotherboard();
        public abstract Ram PrepareRam();
    }
}
