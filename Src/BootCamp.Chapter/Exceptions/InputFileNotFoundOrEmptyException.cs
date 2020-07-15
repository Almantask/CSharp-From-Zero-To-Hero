using System;

namespace BootCamp.Chapter
{
    class InputFileNotFoundOrEmptyException : Exception
    {
        private readonly string _msg;

        public InputFileNotFoundOrEmptyException(string error)
        {
            _msg = error;
        }

        public override string Message { get { return _msg; } }
    }
}
