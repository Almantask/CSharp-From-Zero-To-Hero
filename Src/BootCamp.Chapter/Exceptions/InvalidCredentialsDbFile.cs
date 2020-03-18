using System;

namespace BootCamp.Chapter
{
    public class InvalidCredentialsDbFile : Exception

    {
        public InvalidCredentialsDbFile(string message) : base(message)
        {
        }

        public InvalidCredentialsDbFile(string message, Exception innerException) : base(message, innerException)
        {
        }

        public InvalidCredentialsDbFile()
        {
        }
    }
}