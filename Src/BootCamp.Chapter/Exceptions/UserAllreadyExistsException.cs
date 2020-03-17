using System;
using System.Collections.Generic;
using System.Text;

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