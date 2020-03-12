using BootCamp.Chapter.LogUtility;
using System.IO;

namespace BootCamp.Chapter
{
    public class Logger
    {
        private const string LogPath = @"..\..\..\Output\Log.txt";

        public Logger()
        {
            File.Delete(LogPath);
        }

        private ILogger SetLogOption()
        {
            return new ConsoleLogger();
            //return new FileLogger(LogPath);
        }

        public void Log(string msg)
        {
            SetLogOption().Log(msg);
        }
    }
}
