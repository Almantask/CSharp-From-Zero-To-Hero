using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public class ConsoleLogger : IOutputLogger
	{
		public string BootMessage { get; }
		public string ShutdownMessage { get; }
		//public string ErrorMessage { get; }

		public ConsoleLogger()
		{
			this.BootMessage = "Program has booted.";
			this.ShutdownMessage = "Program has shut down.";
			//this.ErrorMessage = "An error has occured.";
		}

		public void WriteLine(string message)
		{
			Console.WriteLine(message);
		}
		public void Write(string message)
		{
			Console.Write(message);
		}
		public void WriteBootMessage()
		{
			this.WriteLine(this.BootMessage);
		}
		public void WriteShutdownMessage()
		{
			this.WriteLine(this.ShutdownMessage);
		}
		public void WriteErrorMessage(string errorMessage)
		{
			this.WriteLine(errorMessage);
		}
	}
}
