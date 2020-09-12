using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string reason, Exception innerException)
            : base(reason, innerException)
        {
            Console.WriteLine($"{reason} is invalid data.");
        }
    }
}