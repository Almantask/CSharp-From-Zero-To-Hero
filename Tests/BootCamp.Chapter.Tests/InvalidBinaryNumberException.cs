using System;

namespace BootCamp.Chapter.Tests
{
    public class InvalidBinaryNumberException: Exception
    {
        public InvalidBinaryNumberException(string number)
            : base($"{number} is not a binary number.")
        {
        }
    }
}