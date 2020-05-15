using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class InvalidBalancesException : Exception
    {
        private readonly string _msg;
        public InvalidBalancesException(string error)
        {
            _msg = error;
        }
        public override string Message
        {
            get
            {
                return _msg;
            }

        }
    }
}
