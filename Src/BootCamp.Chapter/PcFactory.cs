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
            AssembleBody();
            AssembleCpu();
            AssembleGpu();
            AssembleHardDisk();
            AssembleMotherboard();
            AssembleRam();
            return new DesktopComputer(body, cpu, gpu, disk, board, ram);
        }

        public abstract void AssembleBody();
        public abstract void AssembleCpu();
        public abstract void AssembleGpu();
        public abstract void AssembleHardDisk();
        public abstract void AssembleMotherboard();
        public abstract void AssembleRam();
    }
}
