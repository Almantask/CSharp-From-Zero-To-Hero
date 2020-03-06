using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public abstract class ComputerFactory
    {
        protected Body _body;
        protected Motherboard _motherboard;
        protected HardDisk _hard;
        protected Cpu _cpu;
        protected Gpu _gpu;
        protected Ram _ram;

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
