using System;

namespace BootCamp.Chapter
{
    public class ConsoleLog : ILogger

    {
        public ConsoleLog()
        {
            Boot();
        }
        public void Error(string error)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Error: ");
            Console.WriteLine(error);
            Console.ResetColor();
        }

        public void Message(string message)
        {
            Console.Write("Message: ");
            Console.WriteLine(message);
        }

        public void Boot()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Console logger has booted");
            Console.ResetColor();
        }

        public void Shutdown()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Program has shut down");
            Console.ResetColor();
        }
    }
}