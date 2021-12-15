using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class TextableAttribute : Attribute
    {
        //[TextTable(padding, sideTop, sideLeft, corner)]
        public int Padding { get; }
        public string SideTop { get; }
        public string SideLeft { get; }
        public string Corner { get; }

        public TextableAttribute(int padding, string sideTop, string sideLeft, string corner)
        {
            Padding = padding;
            SideTop = sideTop;
            SideLeft = sideLeft;
            Corner = corner;
        }

    }
}
