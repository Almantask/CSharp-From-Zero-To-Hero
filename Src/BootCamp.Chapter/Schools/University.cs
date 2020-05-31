using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class University<TStudent> : SchoolBase<TStudent> where TStudent : IStudent
    {
    }
}
