using System;

namespace BootCamp.Chapter
{
    interface IInputMonitor<TInput> where TInput : struct
    {
        public event EventHandler<InputPressedEventArgs<TInput>> InputPressed;
        void MonitorInput(TInput input);
    }
}
