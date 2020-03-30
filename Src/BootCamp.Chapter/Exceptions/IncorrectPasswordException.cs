using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    class IncorrectPasswordException : Exception
    {
        private readonly string _message;
        public IncorrectPasswordException(string message)
        {
            _message = message;

        }
        public override string Message
        {
            get
            {
                return _message;
            }

        }
    }
}
