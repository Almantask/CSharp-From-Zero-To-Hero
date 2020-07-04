using BootCamp.Chapter.DataReader;
using System;

namespace BootCamp.Chapter.UserInput
{
    public class InputWatcher : IInputWatcher<ConsoleKey>
    {
        public event EventHandler<InputPressedEventArgs<ConsoleKey>> InputPressed;

        public void MonitorInput(ConsoleKey input)
        {
            OnInputPressed(input);
        }

        // We wrap the event in a protected virtual method
        // to enable derived classes to raise this event.
        protected virtual void OnInputPressed(ConsoleKey inputKey)
        {
            InputPressed?.Invoke(this, new InputPressedEventArgs<ConsoleKey>(inputKey));
        }
    }
}
