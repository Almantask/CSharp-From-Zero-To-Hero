using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public class ComputerFactory
	{
		public DesktopComputer Assemble()
		{
			DesktopComputer computer = new DesktopComputer();

			//Add components
			PrepareBody(computer);
			InstallCpu(computer);
			InstallRam(computer);
			InstallGpu(computer);
			InstallHardDisk(computer);
			InstallMotherboard(computer);

			return computer;
		}

		protected virtual void PrepareBody(DesktopComputer computer)
		{
			computer.SetBody(new Body("Normal Body"));
		}
		protected virtual void InstallCpu(DesktopComputer computer)
		{
			computer.SetCpu(new Cpu("Normal CPU"));
		}
		protected virtual void InstallRam(DesktopComputer computer)
		{
			computer.SetRam(new Ram("Normal Ram"));
		}
		protected virtual void InstallGpu(DesktopComputer computer)
		{
			computer.SetGpu(new Gpu("Normal GPU"));
		}
		protected virtual void InstallHardDisk(DesktopComputer computer)
		{
			computer.SetHard(new HardDisk("Normal Hard Disk"));
		}
		protected virtual void InstallMotherboard(DesktopComputer computer)
		{
			computer.SetMotherboard(new Motherboard("Normal Motherboard"));
		}
	}
}
