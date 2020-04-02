using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class ContactsFileIsEmptyException : Exception
    {
        public ContactsFileIsEmptyException() : base()
        {
        }

        public ContactsFileIsEmptyException(string message) : base(message)
        {
        }

        public ContactsFileIsEmptyException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}