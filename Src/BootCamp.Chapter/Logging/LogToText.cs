using System;
using System.IO;

namespace BootCamp.Chapter.Logging
{
    abstract class LogToText : ILog, IConnection
    {

        private string _Connection = @"\LogToText.txt";
        public string GetConnection()
        {
            return _Connection;
        }

        public void LogOpenProgram()
        {
            //Write To Text
        }
        public void LogCloseProgram()
        {
            //Write To Text
        }
        public void LogCrash(Exception e)
        {
            //Write To Text
        }
        var fileS = new FileStream(GetConnection(), FileMode.Create);
                using (var writer = new StreamWriter(fileS))
                {
                    writer.Write(cleanFile);
                }
            }
    }
}
