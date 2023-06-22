using BootCamp.Chapter.Computer;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
	class Program
	{
		static void Main(string[] args)
		{
			//Create 2 of each factory (Mac/Ms)
			ComputerFactory[] computerFactories =
			{
				new MacFactory(),
				new MacFactory(),
				new MsFactory(),
				new MsFactory()
			};

			//Build 100 PCs in each factory
			List<DesktopComputer> computers = new List<DesktopComputer>();
			foreach (ComputerFactory computerFactory in computerFactories)
			{
				for (int i = 0; i < 100;  i++)
				{
					computers.Add(computerFactory.Assemble());
				}
			}

			Console.WriteLine($"{computers.Count} PCs made.");
			Console.ReadLine();
		}
	}
}
