using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            var textLogger = new Logging.LogToText();
            var consoleLogger = new Logging.LogToConsole();

            Test(consoleLogger);
            Test(textLogger);
        }

        public static void Test(ILog logger)
        {
            Console.WriteLine($"I will now start logging to {logger.Type()}.");
            logger.LogNow("Start Time of program.");
            try
            {
                Doktor.DoctorAsks();
            }
            catch (Exception e)
            {
                logger.LogNow($"Program Crashed. Reason: {e.Message}");

            }

            logger.LogNow("Program closed.");
        }
    }
}
