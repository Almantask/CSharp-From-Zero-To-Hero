using System;

namespace BootCamp.Chapter
{
    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {
        }

        public InvalidPasswordException(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidPasswordException()
        {
        }
    }
}