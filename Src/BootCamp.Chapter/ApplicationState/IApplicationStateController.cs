using System;

namespace BootCamp.Chapter.ApplicationState
{
    public interface IApplicationStateController
    {
        // We use the generic EventHandler type provided by .NET, thus we don't have to create our own.
        public event EventHandler<ApplicationStateEventArgs> ApplicationStateChanged;
        void ChangeState(ApplicationStates state);
    }
}
