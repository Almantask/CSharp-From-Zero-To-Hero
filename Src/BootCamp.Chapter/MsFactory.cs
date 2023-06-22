using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Computer;

namespace BootCamp.Chapter
{
    public class MsFactory : ComputerFactory
	{
		protected override void PrepareBody(DesktopComputer computer)
		{
			computer.SetBody(new Body("Win Body"));
		}
		protected override void InstallCpu(DesktopComputer computer)
		{
			computer.SetCpu(new Cpu("Win CPU"));
		}
		protected override void InstallRam(DesktopComputer computer)
		{
			computer.SetRam(new Ram("Win Ram"));
		}
		protected override void InstallGpu(DesktopComputer computer)
		{
			computer.SetGpu(new Gpu("Win GPU"));
		}
		protected override void InstallHardDisk(DesktopComputer computer)
		{
			computer.SetHard(new HardDisk("Win Hard Disk"));
		}
		protected override void InstallMotherboard(DesktopComputer computer)
		{
			computer.SetMotherboard(new Motherboard("Win Motherboard"));
		}
	}
}
