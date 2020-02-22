using System;

namespace BootCamp.Chapter.Tests
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException()
        {
        }

        public InvalidBalancesException(string message) : base(message)
        {
        }

        public InvalidBalancesException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}