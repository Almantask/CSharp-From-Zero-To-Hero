using BootCamp.Chapter.LogUtility;
using System;

namespace BootCamp.Chapter
{
    class InvalidUnexpectedException : ArgumentException
    {
        public InvalidUnexpectedException(int option) : base ($"Unexpected logger option '{option}'.")
        {

        }
    }
}
