using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class ConsoleLogger : ILogger
    {
        private string _message;

        public ConsoleLogger()
        {
        }

        public ConsoleLogger(string message)
        {
            _message = message;
        }

        public void SetMessage(string message)
        {
            _message = message;
        }

        public string GetMessage()
        {
            return _message;
        }

        public void Log()
        {
            Console.WriteLine(_message);
        }
    }
}