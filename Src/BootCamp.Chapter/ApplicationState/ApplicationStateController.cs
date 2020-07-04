using System;


namespace BootCamp.Chapter.ApplicationState
{
    public class ApplicationStateController
    {
        // We use the generic EventHandler type provided by .NET, thus we don't have to create our own.
        public event EventHandler<ApplicationStateEventArgs> ApplicationStateChanged;

        public void ChangeState(ApplicationStates newState)
        {
            OnApplicationStateChange(newState);
        }

        // We wrap the event in a protected virtual method
        // to enable derived classes to raise this event.
        protected virtual void OnApplicationStateChange(ApplicationStates inputState)
        {
            ApplicationStateChanged?.Invoke(this, new ApplicationStateEventArgs(inputState));
        }
    }
}
