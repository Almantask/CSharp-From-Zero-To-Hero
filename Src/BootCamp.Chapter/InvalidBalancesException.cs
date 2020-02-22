using System;

namespace BootCamp.Chapter.Tests
{
    internal class InvalidBalancesException : Exception
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