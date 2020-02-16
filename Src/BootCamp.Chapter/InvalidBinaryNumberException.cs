using System;

namespace BootCamp.Chapter
{
    public class InvalidBinaryNumberException: Exception
    {
        public InvalidBinaryNumberException(string number)
            : base($"{number} is not a binary number.")
        {
        }
    }
}