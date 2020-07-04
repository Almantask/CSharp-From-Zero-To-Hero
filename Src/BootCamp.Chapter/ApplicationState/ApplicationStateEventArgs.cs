using System;

namespace BootCamp.Chapter.ApplicationState
{
    public class ApplicationStateEventArgs : EventArgs
    {
        public DateTime TimeFired { get; }
        public ApplicationStates State { get; }

        public ApplicationStateEventArgs(ApplicationStates applicationState)
        {
            TimeFired = DateTime.Now;
            State = applicationState;
        }
    }
}
