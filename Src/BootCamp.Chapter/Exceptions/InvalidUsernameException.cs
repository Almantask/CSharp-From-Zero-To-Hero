using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class InvalidUsernameException : Exception
    {
        public InvalidUsernameException() { }

        public InvalidUsernameException(string message) : base(message) { }

        public InvalidUsernameException(string message, Exception innerException) : base(message, innerException) { }
    }
}
