using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Subjects
{
    public class English : ISubject
    {
        public override string ToString()
        {
            return string.Format($"english");
        }
    }
}
