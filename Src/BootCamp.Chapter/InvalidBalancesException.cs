using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException() { }
        public InvalidBalancesException(string message) : base(message) { }
    }
}