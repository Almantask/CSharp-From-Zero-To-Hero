using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Subjects
{
    public class Music : ISubject
    {
        public override string ToString()
        {
            return string.Format($"music");
        }
    }
}
