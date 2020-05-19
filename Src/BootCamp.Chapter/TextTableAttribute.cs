using System;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class TextTableAttribute : Attribute
    {
        public int Padding { get; }
        public char SideTop { get; }
        public char SideLeft { get; }
        public char Corner { get; }
        
        public TextTableAttribute(int padding = 0, char sideTop = '-', char sideLeft = '|', char corner = '+')
        {
            Padding = padding;
            SideTop = sideTop;
            SideLeft = sideLeft;
            Corner = corner;
        }
    }
}
