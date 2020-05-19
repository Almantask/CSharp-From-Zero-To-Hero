using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class InvalidDatabaseFileException : Exception
    {
        public InvalidDatabaseFileException() : base() { }

        public InvalidDatabaseFileException(string message) : base(message) { }

        public InvalidDatabaseFileException(string message, Exception innerException) : base(message, innerException) { }
    }
}
