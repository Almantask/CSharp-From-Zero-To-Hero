using System;

namespace BootCamp.Chapter.UserInput
{
    public class InputPressedEventArgs<TInput> : EventArgs where TInput : struct
    {
        public DateTime TimeFired { get; }
        public TInput Input { get; }

        public InputPressedEventArgs(TInput input)
        {
            TimeFired = DateTime.Now;
            Input = input;
        }
    }
}
