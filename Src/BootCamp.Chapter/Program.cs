using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var logger = new ConsoleLogger();
            BMICalculatorLogger.Info(logger);
        }
    }
}
