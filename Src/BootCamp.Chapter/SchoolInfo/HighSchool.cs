using BootCamp.Chapter.StudentInfo;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.SchoolInfo
{

    internal class HighSchool<TStudent> : ISchool<TStudent, TId> where TStudent : HighSchoolStudent<HighSchoolTeacher>
    {
        public List<TStudent> students { get; set; }

        public void Add(TStudent student)
        {
            students.Add(student);
        }

        public TStudent Get(TId id)
        {
            foreach (var student in students)
            {
                if (student.Id == id)
                {
                    return student;
                }

            }

            return null;
        }

        public IList<TStudent> Get()
        {
            return students;
        }
    }
}

