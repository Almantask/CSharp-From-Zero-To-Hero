using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public sealed class TextTableAttribute : Attribute
    {
        public int Padding { get; }
        // sideTop
        public char Horizontal { get; }
        // sideLeft/Right
        public char Vertical { get; }
        public char Corner { get; }

        public TextTableAttribute(int padding = 0, char horizontal = '-', char vertical = '|', char corner = '+')
        {
            Padding = padding;
            Horizontal = horizontal;
            Vertical = vertical;
            Corner = corner;
        }
    }
}
