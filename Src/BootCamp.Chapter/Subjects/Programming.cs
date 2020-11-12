using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Subjects
{
    public class Programming : ISubject
    {
        public override string ToString()
        {
            return string.Format($"programming");
        }
    }
}
