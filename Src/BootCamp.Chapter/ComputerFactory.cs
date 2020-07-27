using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        public DesktopComputer Assemble()
        {
            Body body = GetBody();
            Ram ram = GetRam();
            Cpu cpu = GetCpu();
            Gpu gpu = GetGpu();
            HardDisk hardDisk =  GetHardDisk();
            Motherboard motherboard = GetMotherboard();

            return new DesktopComputer(body, ram, cpu, gpu, hardDisk, motherboard);

    }

        public abstract Body GetBody();
        public abstract Ram GetRam();
        public abstract Cpu GetCpu();
        public abstract Gpu GetGpu();
        public abstract HardDisk GetHardDisk();
        public abstract Motherboard GetMotherboard();

    }
}
