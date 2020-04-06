using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    class HighSchool<TStudent, TTeacher> : School<TStudent, TTeacher> where TStudent : HighSchoolStudent where TTeacher : HighSchoolTeacher<ISubject>
    {
        /*
        List<TStudent> students;
        List<TTeacher> teachers;
        long Id { get; set; }
        public HighSchool()
        {
            Id = 0;
            students = new List<TStudent>();
            teachers = new List<TTeacher>();
        }
        public void AddTeacher(TTeacher teacher)
        {
            teachers.Add(teacher);
        }

        public void AddStudent(TStudent student)
        {
            students.Add(student);
            //student.Id = Id;
            Id++;
        }
        */
    }
}
