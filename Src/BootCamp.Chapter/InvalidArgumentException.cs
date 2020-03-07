using System;

namespace BootCamp.Chapter
{
    public class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(string reason, Exception innerException)
            : base($"The corrupted file '{reason}' does not exist.", innerException)
        {

        }
    }
}
