using System;

namespace BootCamp.Chapter
{
    class InputMonitor : IInputMonitor<ConsoleKey>
    {
        public event EventHandler<InputPressedEventArgs<ConsoleKey>> InputPressed;

        public void MonitorInput(ConsoleKey input)
        {
            OnInputPressed(input);
            
        }

        protected virtual void OnInputPressed(ConsoleKey keyPressed)
        {
            InputPressed?.Invoke(this, new InputPressedEventArgs<ConsoleKey>(keyPressed));
        }
    }
}
