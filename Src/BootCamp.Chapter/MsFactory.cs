using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory:DesktopComputer
    {
        public DesktopComputer Assemble()
        {
            DesktopComputer desktop = new DesktopComputer();
            WotkFlow(desktop);
            return desktop;
        }

        public override void WotkFlow(DesktopComputer des)
        {
            des.SetBody(new Body("Win Body"));
            des.SetCpu(new Cpu("Win Cpu"));
            des.SetRam(new Ram("Win Ram"));
            des.SetGpu(new Gpu("Win Gpu"));
            des.SetHardDisk(new HardDisk("Win HardDisk"));
            des.SetMotherBoard(new Motherboard("Win MotherBoard"));
        }
    }
}
