using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string reason) : base(reason) { }

        public InvalidBalancesException(string reason, Exception innerException) : base(reason, innerException) { }
    }
}