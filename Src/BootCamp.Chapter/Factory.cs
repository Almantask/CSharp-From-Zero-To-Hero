using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public abstract class Factory
    {
        public abstract void Body(DesktopComputer desktop);
        public abstract void Ram(DesktopComputer desktop);
        public abstract void Cpu(DesktopComputer desktop);
        public abstract void Gpu(DesktopComputer desktop);
        public abstract void HardDisk(DesktopComputer desktop);
        public abstract void Motherboard(DesktopComputer desktop);
    }
}
