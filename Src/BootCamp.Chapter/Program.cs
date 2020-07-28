using BootCamp.Chapter.Logger;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = ChooseLogger();
            logger.LogMessage("Starting program.");
            logger.LogMessage("Program shutting down.");
        }

        static public ILogger ChooseLogger()
        {
            while (true)
            {
                Console.WriteLine("Please choose logger option: 'a' - console; 'b' - file");
                string loggerChoice = Console.ReadLine();
                if (loggerChoice == "a")
                {
                    return new ConsoleLogger();
                }
                else if (loggerChoice == "b")
                {
                    return new FileLogger();
                }
                Console.WriteLine("Please choose: 'a' - console; 'b' - file");
            }
        }
    }
}
