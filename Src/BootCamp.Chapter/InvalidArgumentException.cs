using System;

namespace BootCamp.Chapter
{
    class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string message) : base(message)
        {
        }
    }
}
