using BootCamp.Chapter.Logger;

namespace BootCamp.Chapter
{
    public static class LogSystem
    {
        // Debug Level:
        //     "Console"
        //     "File"
        private const string DebugLevel = "Console";
        
        public static ILogger SetLogMode()
        {
            if (DebugLevel == "Console")
            {
                return new ConsoleLogger();
            }
            else
            {
                return new FileLogger(@"Log.txt");
            }
        }
    }
}