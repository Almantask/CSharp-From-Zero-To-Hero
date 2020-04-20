using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class InvalidPeoplesFileException : Exception
    {
        public string Message { get; set; }
        public InvalidPeoplesFileException(string msg)
        {
            Message = msg;
        }
    }
}
