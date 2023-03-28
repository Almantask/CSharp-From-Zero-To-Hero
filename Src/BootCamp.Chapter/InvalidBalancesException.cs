using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        public InvalidBalancesException(string reason, Exception innerException)
            : base(reason, innerException)
        {
        }
    }
    public class InvalidBPersonNameException : Exception
    {
        public InvalidBPersonNameException(string name)
            : base($"{name} contains invalid characters")
        {
        }
    }
    public class InvalidBalanceException : Exception
    {
        public InvalidBalanceException(string value)
            : base($"{value} contains invalid characters")
        {
        }
    }
}
