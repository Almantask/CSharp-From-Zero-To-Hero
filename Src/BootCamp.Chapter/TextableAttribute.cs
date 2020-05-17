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
        public int Padding { get; }
        public char Horizontal { get; }
        public char Vertical { get; }
        public char Corner { get; }

        public TextableAttribute(int padding = 0, char horizontal = '-', char vertical = '|', char corner = '+')
        {
            Padding = padding;
            Horizontal = horizontal;
            Vertical = vertical;
            Corner = corner;
        }
        
    }
}
