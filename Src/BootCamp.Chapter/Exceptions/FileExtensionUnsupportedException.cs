using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Exceptions
{
    class FileExtensionUnsupportedException : Exception
    {
        public FileExtensionUnsupportedException() : base()
        {
        }

        public FileExtensionUnsupportedException(string message) : base(message)
        {
        }

        public FileExtensionUnsupportedException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
