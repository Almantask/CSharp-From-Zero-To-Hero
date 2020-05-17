using System;
using System.Collections.Generic;
using System.Text;

/*
 * // Print attribute can be applied everywhere.
    // It can also be used multiple times on the same target.
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class PrintAttribute : Attribute
    {
        public string Message { get; }

        public PrintAttribute(string message)
        {
            Message = message;
        }
    }
    */

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public sealed class TextableAttribute : Attribute
    {
        int padding { get; }
        char horizontal { get; }
        char vertical { get; }
        char corner { get; }

        public TextableAttribute(int padding = 0, char horizontal = '-', char vertical = '|', char corner = '+')
        {

        }
    }
}
