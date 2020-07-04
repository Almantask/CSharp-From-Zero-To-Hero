using System;

namespace BootCamp.Chapter.UserInput
{
    public class InputWatcher : IInputWatcher
    {
        // We use the generic EventHandler type provided by .NET, thus we don't have to create our own.
        public event EventHandler<InputPressedEventArgs> InputPressed;

        public void GetInput(ConsoleKey consoleKey)
        {
            OnInputPressed(consoleKey);
        }

        // We wrap the event in a protected virtual method
        // to enable derived classes to raise this event.
        protected virtual void OnInputPressed(ConsoleKey inputKey)
        {
            InputPressed?.Invoke(this, new InputPressedEventArgs());
        }
    }
}
