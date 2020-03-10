using BootCamp.Chapter.LogUtility;
using System;

namespace BootCamp.Chapter
{
    class InvalidArgumentException : ArgumentException
    {
        public InvalidArgumentException(int option) : base ($"Unexpected logger option '{option}'.")
        {

        }
    }
}
