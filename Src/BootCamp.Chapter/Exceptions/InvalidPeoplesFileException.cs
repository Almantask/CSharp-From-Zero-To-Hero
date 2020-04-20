using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class InvalidPeoplesFileException : Exception
    {
        public InvalidPeoplesFileException(string msg) : base(msg)
        {
        }
    }
}
