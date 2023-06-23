using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
	public interface IOutputLogger
	{
		//Message given when program boots
		public string BootMessage { get; }
		//Message given when program shuts down
		public string ShutdownMessage { get; }
		//Message given when program runs into an error
		//public string ErrorMessage { get; }
		//Write message with trailing new line character
		public void WriteLine(string message);
		//Write message
		public void Write(string message);
		//Write boot message
		public void WriteBootMessage();
		//Write shut down message
		public void WriteShutdownMessage();
		//Write error message
		public void WriteErrorMessage(string errorMessage);
	}
}
