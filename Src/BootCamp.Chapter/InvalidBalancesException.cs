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
}
