using System.IO;

namespace BootCamp.Chapter
{
    public class FileLog : ILogger

    {
        private string _path;
        

        /// <param name="filepath">Filepath must be a directory to a file where the log will be stored</param>
        public FileLog(string filepath)
        {
            _path = filepath;
            Boot();
        }
        public void Error(string error)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.Write("Error: ");
                sw.WriteLine(error);
            }
        }

        public void Message(string message)
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.Write("Message: ");
                sw.WriteLine(message);
            }
        }

        public void Boot()
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine("File logger has booted");
            }
        }

        public void Shutdown()
        {
            using (StreamWriter sw = File.AppendText(_path))
            {
                sw.WriteLine("Program has shut down");
            }
        }
    }
}