using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp1.Chapter.WordLoader
{
    public class InvalidWordsFileException: Exception
    {
        public InvalidWordsFileException(string message) : base(message)
        {
        }
    }
}
