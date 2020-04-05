using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    interface ISchool<TStudent, TTeacher> where TStudent : IStudent where TTeacher : ITeacher<ISubject>
    {
        public void AddStudent(TStudent student);
        public void AddTeacher(TTeacher teacher);
    }
}
