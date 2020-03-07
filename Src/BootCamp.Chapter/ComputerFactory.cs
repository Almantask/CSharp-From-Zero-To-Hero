using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        protected readonly Body _body;
        protected readonly Motherboard _motherboard;
        protected readonly HardDisk _hard;
        protected readonly Cpu _cpu;
        protected readonly Gpu _gpu;
        protected readonly Ram _ram;

        protected ComputerFactory()
        {
            _body = new Body();
            _motherboard = new Motherboard();
            _hard = new HardDisk();
            _cpu = new Cpu();
            _gpu = new Gpu();
            _ram = new Ram();
        }

        public abstract DesktopComputer Assemble();
    }
}
