using System;

namespace BootCamp.Chapter
{
    public class NoTransactionsFoundException : Exception
    {
        public NoTransactionsFoundException()
        {
        }

        public NoTransactionsFoundException(string message) : base(message)
        {
        }

        public NoTransactionsFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}