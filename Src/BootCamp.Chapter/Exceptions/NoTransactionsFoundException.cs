using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class NoTransactionsFoundException : Exception
    {
        private readonly string _msg;

        public NoTransactionsFoundException(string error)
        {
            _msg = error;
        }

        public override string Message { get { return _msg; } }
    }
}
