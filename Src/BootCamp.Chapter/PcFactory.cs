using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class PcFactory
    {
        protected Body body;
        protected Cpu cpu;
        protected Gpu gpu;
        protected HardDisk disk;
        protected Motherboard board;
        protected Ram ram;

        public DesktopComputer Assemble()
        {
            PrepareBody();
            PrepareCpu();
            PrepareGpu();
            PrepareHardDisk();
            PrepareMotherboard();
            PrepareRam();
            return new DesktopComputer(body, cpu, gpu, disk, board, ram);
        }

        public abstract void PrepareBody();
        public abstract void PrepareCpu();
        public abstract void PrepareGpu();
        public abstract void PrepareHardDisk();
        public abstract void PrepareMotherboard();
        public abstract void PrepareRam();
    }
}
