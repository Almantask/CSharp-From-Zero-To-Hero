using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string message)
        {
            Console.WriteLine(message);
        }
    }
}