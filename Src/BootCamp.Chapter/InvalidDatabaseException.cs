using System;

namespace BootCamp.Chapter
{
    class InvalidDatabaseException : ApplicationException
    {
        public InvalidDatabaseException(string msg) : base(msg)
        {
        }
    }
}
