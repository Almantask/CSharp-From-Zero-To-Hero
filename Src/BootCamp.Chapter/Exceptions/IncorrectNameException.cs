using System;

namespace BootCamp.Chapter.Exceptions
{
    public class IncorrectNameException : Exception
    {
        private readonly string _message;
        public IncorrectNameException(string message)
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
