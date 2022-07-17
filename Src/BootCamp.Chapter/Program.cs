namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger[] loggers = { new ConsoleLog(), new FileLog(@"C:\Users\FURI01\Documents\log.log") };
            foreach (var logger in loggers)
            {
                logger.Message("Log message #1");
                logger.Error("oh no an error");
                logger.Message("Error fixed");
                logger.Error("Another error");
                logger.Error("Error is worse");
                logger.Error("System is crashing");
                logger.Shutdown();
            }
        }
    }
}
