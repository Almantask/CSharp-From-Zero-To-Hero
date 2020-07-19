using System;

namespace BootCamp.Chapter.Exceptions
{
    public class InvalidCommandException : Exception
    {
        private readonly string _msg;

        public InvalidCommandException(string error) 
        {
            _msg = error;
        }

        public override string Message { get { return _msg; } }
    }
}
