using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory:DesktopComputer
    {
        public DesktopComputer Assemble()
        {
            DesktopComputer desktop = new DesktopComputer();
            WotkFlow(desktop);
            return desktop;
        }

        public override void WotkFlow(DesktopComputer des)
        {
            des.SetBody(new Body("Mac Body"));
            des.SetCpu(new Cpu("Mac Cpu"));
            des.SetRam(new Ram("Mac Ram"));
            des.SetGpu(new Gpu("Mac Gpu"));
            des.SetHardDisk(new HardDisk("Mac HardDisk"));
            des.SetMotherBoard(new Motherboard("Mac MotherBoard"));
        }
    }
}
