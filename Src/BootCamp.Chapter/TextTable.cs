using System;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false)]
    public sealed class TextTable : Attribute
    {
        public readonly int Padding;
        public readonly char SideTop;
        public readonly char SideLeft;
        public readonly char Corner;

        public TextTable(int padding, char sideTop, char sideLeft, char corner)
        {
            Padding = padding;
            SideTop = sideTop;
            SideLeft = sideLeft;
            Corner = corner;
        }
    }
}