using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class InvalidAgeException: Exception
    {
        public InvalidAgeException(string age, string message) 
            : base($"{age} is not a valid age. Reason: {message}.")
        {
        }
    }
}
