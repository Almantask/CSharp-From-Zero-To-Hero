using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class AppRunningEventArgs : EventArgs
    {
		public DateTime TimeOfEvent { get; private set; }
		public string Message { get; private set; }

		public AppRunningEventArgs(DateTime time, string message)
		{
			TimeOfEvent = time;
			Message = message;
		}
	}
}
