using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            // Initialising the type of logger for the entire application
            ILogger typeoflogger = InitialiseLogger();
            
            // Simulating the logger through using a Calculator Sim
            var calculate = new CalculatorSimulator(typeoflogger);

            // hardcoded values while de-bugging
            calculate.Add(1, 10);
            calculate.Subtract(10, 9);
            Console.Read();
        }

        // enum for Logging Options to make code more readable
        enum LoggingOptions
        {
            File,
            Console
        }
                
        private static ILogger InitialiseLogger()
        {
            while (true)
            {
                Console.WriteLine("Would you like to create a Log File (1) or Log in Console (2) to track activity?");
                var option = Int32.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)LoggingOptions.File:
                        return new FileLogger();

                    case (int)LoggingOptions.Console:
                        return new ConsoleLogger();

                    default:
                        break;
                }
            }
        }
    }
}
