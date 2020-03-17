using System;

namespace BootCamp.Chapter
{
    public class UserAllreadyExistsException : Exception
    {
        public UserAllreadyExistsException(string message) : base(message)
        {
        }

        public UserAllreadyExistsException()
        {
        }

        public UserAllreadyExistsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}