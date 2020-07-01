using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class HighSchool<TStudent> : School<TStudent> where TStudent : HighSchoolStudent
    {
        public HighSchool(string name, string location) : base(name, location) { }
    }
}
