using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MacFactory : ComputerFactory
    {
		protected override void PrepareBody(DesktopComputer computer)
		{
			computer.SetBody(new Body("Mac Body"));
		}
		protected override void InstallCpu(DesktopComputer computer)
		{
			computer.SetCpu(new Cpu("Mac CPU"));
		}
		protected override void InstallRam(DesktopComputer computer)
		{
			computer.SetRam(new Ram("Mac Ram"));
		}
		protected override void InstallGpu(DesktopComputer computer)
		{
			computer.SetGpu(new Gpu("Mac GPU"));
		}
		protected override void InstallHardDisk(DesktopComputer computer)
		{
			computer.SetHard(new HardDisk("Mac Hard Disk"));
		}
		protected override void InstallMotherboard(DesktopComputer computer)
		{
			computer.SetMotherboard(new Motherboard("Mac Motherboard"));
		}
	}
}
