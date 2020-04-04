using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class MiddleSchool : ISchool<MiddleSchoolStudent>
    {
        List<MiddleSchoolStudent> students;

        public MiddleSchool()
        {
            students = new List<MiddleSchoolStudent>();
        }
        public void Add(MiddleSchoolStudent student)
        {
            students.Add(student);
        }
    }
}
