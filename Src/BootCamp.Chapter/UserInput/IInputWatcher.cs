using System;

namespace BootCamp.Chapter.UserInput
{
    public interface IInputWatcher<TInput> where TInput : struct
    {
        // We use the generic EventHandler type provided by .NET, thus we don't have to create our own.
        public event EventHandler<InputPressedEventArgs<TInput>> InputPressed;
        void MonitorInput(TInput input);
    }
}
