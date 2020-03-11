using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var textLogger = new Logging.LogToText();
            var consoleLogger = new Logging.LogToConsole();

            Test(consoleLogger);
            Test(textLogger);
        }

        public static void Test(ILog logger)
        {
            logger.LogOpenProgram();
            try
            {
                Doktor.DoctorAsks();
            }
            catch (Exception e)
            {
                logger.LogCrash(e);
            }

            logger.LogCloseProgram();
        }
    }
}
