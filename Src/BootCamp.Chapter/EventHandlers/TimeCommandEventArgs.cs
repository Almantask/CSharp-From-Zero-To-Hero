using System;
using System.Collections.Generic;

namespace BootCamp.Chapter.EventHandlers
{
    class TimeCommandEventArgs : EventArgs
    {
        public DateTime TimeFired { get;}
        public string Command { get; }

        public TimeCommandEventArgs(string command)
        {
            TimeFired = DateTime.Now;
            Command = command;
        }
    }
}
