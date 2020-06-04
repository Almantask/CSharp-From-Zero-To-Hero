using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    public class MiddleSchool<TStudent> : School<TStudent> where TStudent : IStudent
    {
        public MiddleSchool(string name, string location) : base (name, location) { }
    }
}
