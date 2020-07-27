using System;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public sealed class TextTableAttribute : Attribute
    {
        public int Padding { get; }
        public char Horizontal { get; }
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
