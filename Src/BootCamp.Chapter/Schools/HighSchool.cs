using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class HighSchool : ISchool<HighSchoolStudent>
    {
        List<HighSchoolStudent> students;

        public HighSchool()
        {
            students = new List<HighSchoolStudent>();
        }

        public void Add(HighSchoolStudent student)
        {
            students.Add(student);
        }
    }
}
