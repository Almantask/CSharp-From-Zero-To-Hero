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

        private ILogger GetLogOption()
        {
            return new ConsoleLogger(); //Use ConsoleLogger() or FileLogger(LogPath) method.
        }

        public void Log(string msg)
        {
            GetLogOption().Log(msg);
        }
    }
}
