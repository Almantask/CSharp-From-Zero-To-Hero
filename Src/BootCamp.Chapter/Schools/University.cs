using BootCamp.Chapter.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class University : ISchool<UniversityStudent>
    {
        List<UniversityStudent> students;

        public University()
        {
            students = new List<UniversityStudent>();
        }
        public void Add(UniversityStudent student)
        {
            students.Add(student);
        }
    }
}
