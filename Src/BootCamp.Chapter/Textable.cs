using System;

namespace BootCamp.Chapter
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public sealed class Textable : Attribute
    {
        public Textable()
        {
        }
    }
}