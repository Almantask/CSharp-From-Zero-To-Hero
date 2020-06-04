using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    public class HighSchool<TStudent> : School<TStudent> where TStudent : IStudent
    {
        public HighSchool(string name, string location) : base (name, location) { }
    }
}
