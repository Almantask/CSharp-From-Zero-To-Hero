using System;
using System.Threading;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "./logger.txt";
            var fileLogger = new FileLogger(file);
            var consoleLogger = new ConsoleLogger();

            TestLogger(consoleLogger);
            TestLogger(fileLogger);

            Environment.Exit(0);
        }

        public static void TestLogger(ILogger logger)
        {            
            logger.LogStart();

            Console.WriteLine("Start");
            Thread.Sleep(1000);

            var foo = new int[0];
            try
            {
                Console.WriteLine(foo[1]);
            }
            catch (Exception ex)
            {
                logger.Error(ex);
            }

            Thread.Sleep(1000);
            logger.LogExit();
        }

    }
}
