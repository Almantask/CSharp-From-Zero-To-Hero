using System;

namespace BootCamp.Chapter.Gambling
{
    public class InvalidGameStateException : Exception
    {
        public InvalidGameStateException(string message) : base(message)
        {
        }
    }
}