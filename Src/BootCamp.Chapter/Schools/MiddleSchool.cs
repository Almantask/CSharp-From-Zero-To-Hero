using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    public class MiddleSchool<TStudent> : SchoolBase<TStudent> where TStudent : IStudent { }
}
