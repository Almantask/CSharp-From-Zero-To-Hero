using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.EventHandlers
{
    class CityCommandEventArgs : EventArgs
    {
        public DateTime TimeFired { get; }
        public string Command { get; }

        public CityCommandEventArgs(string command)
        {
            TimeFired = DateTime.Now;
            Command = command;
        }
    }
}
