using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Students;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Schools
{
    interface ISchool<TStudent, in TTeacher> where TStudent : IStudent where TTeacher : ITeacher<ISubject>
    {
        public TStudent GetStudent(long id);
        public void AddStudent(TStudent student);
        public void AddTeacher(TTeacher teacher);
    }
}
