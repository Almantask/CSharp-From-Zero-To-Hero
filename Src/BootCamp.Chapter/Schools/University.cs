using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class University<TStudent> : School<TStudent> where TStudent : UniversityStudent
    {
        public University(string name, string location) : base(name, location) { }
    }
}
