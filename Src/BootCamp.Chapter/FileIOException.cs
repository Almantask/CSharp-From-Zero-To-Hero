using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class FileIOException : Exception
    {
        public FileIOException(string reason, Exception innerException) : base(reason, innerException)
        {
            Console.WriteLine($"{reason}.");
        }
    }
}
