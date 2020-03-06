using System;


namespace BootCamp.Chapter
{
    class ConsoleLogger : Ilogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"{ message}");
        }
    }
}
