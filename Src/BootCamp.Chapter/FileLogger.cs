using System.IO;


namespace BootCamp.Chapter
{
    class FileLogger : Ilogger
    {
        public void Log(string message)
        {
            File.AppendAllText(@"logs/log.txt", message);
        }
    }
}
