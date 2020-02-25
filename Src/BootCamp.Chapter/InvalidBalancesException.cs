using System;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string invalid) : base($"{invalid} has been found.")
        {

        }
    }
}