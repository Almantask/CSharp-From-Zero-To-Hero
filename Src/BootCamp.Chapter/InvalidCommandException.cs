using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class InvalidCommandException : Exception
    {
        public InvalidCommandException() : base()
        {
        }

        public InvalidCommandException(string message) : base(message)
        {
        }

        public InvalidCommandException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
