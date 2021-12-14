using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class TextableAttribute : Attribute
    {
        public string Message { get; }

        public TextableAttribute(string message)
        {
            Message = message;
        }

    }
}
