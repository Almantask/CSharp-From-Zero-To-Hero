using System.IO;

namespace BootCamp.Chapter.Examples.InvoiceSender
{
    public interface ILogger
    {
        void Log(string message);
    }

    public class Logger : ILogger
    {
        private readonly string _file;

        public Logger(string file)
        {
            _file = file;
        }

        public void Log(string message) => File.WriteAllText(_file,message);
    }
}
