using System;

namespace BootCamp.Chapter.Demo
{
    public class Demos
    {
        public event EventHandler ProgramStatus;
        public event EventHandler KeyPressed;

        public Demos()
        {
            ProgramStatus += Status.ShowStatus;
            KeyPressed += KeyWatcher.PressedKey;
        }
        
        public void Run()
        {
            ProgramStatus?.Invoke("Started", null);
            KeyPressed?.Invoke(GetUserChoice(), null);

            ShutDown();
        }

        private void ShutDown()
        {
            ProgramStatus?.Invoke("Shutting down...", null);
            KeyPressed -= KeyWatcher.PressedKey;
            ProgramStatus -= Status.ShowStatus;
        }
        
        private ConsoleKey GetUserChoice()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("a) over 18, who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("b) under 18,  who do not live in UK, whose surname does not contain letter 'a'.");
            Console.WriteLine("c) who do not live in UK, whose surname and name does not contain letter 'a'.");

            return Console.ReadKey(true).Key;
        }
    }
}