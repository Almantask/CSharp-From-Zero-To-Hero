using System;

namespace BootCamp.Chapter
{
    public class Demo
    {
        public Person person;

        public event EventHandler DemoStarted;

        public event EventHandler ChoosePredicate;

        public event EventHandler DemoEnded;

        public event EventHandler ApplicationClosed;

        public void Run()
        {
            DemoStarted?.Invoke(this, EventArgs.Empty);
            ChoosePredicate?.Invoke(this, EventArgs.Empty);
            DemoEnded?.Invoke(this, EventArgs.Empty);
            ApplicationClosed?.Invoke(this, EventArgs.Empty);
        }
    }
}