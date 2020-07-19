using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    public class OutputPathNotFoundException : Exception
    {
        private readonly string _msg;

        public OutputPathNotFoundException(string error)
        {
            _msg = error;
        }

        public override string Message { get { return _msg; } }
    }
}
