using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Events
{
    public class ApplicationStateEventArgs : EventArgs
    {
        public DateTime TimeFired { get; }
        public ApplicationState State { get; }

        public ApplicationStateEventArgs(ApplicationState applicationState)
        {
            TimeFired = DateTime.Now;
            State = applicationState;
        }
    }
}
