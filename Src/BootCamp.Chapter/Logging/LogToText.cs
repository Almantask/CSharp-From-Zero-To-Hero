using System.IO;

namespace BootCamp.Chapter.Logging
{
    class LogToText : Log, IConnection
    {

        private readonly string _connection = @"C:\Users\Max\Source\Repos\CSharp-From-Zero-To-Hero\Src\BootCamp.Chapter\Logging\Log.txt";
        public string GetConnection()
        {
            return _connection;
        }
        public override void LogNow(string text)
        {
            File.AppendAllText(GetConnection(), text + "\r\n");
        }
    }

}
