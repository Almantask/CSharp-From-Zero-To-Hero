using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Students;

namespace BootCamp.Chapter.Schools
{
    class MiddleSchool<TStudent> : School<TStudent> where TStudent : MiddleSchoolStudent
    {
        public MiddleSchool(string name, string location) : base(name, location) { }
    }
}
