using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Subjects
{
    public class MathWork : ISubject
    {
        public override string ToString()
        {
            return string.Format($"math");
        }
    }
}
