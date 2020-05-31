using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    class MiddleSchoolTeacher<TSubject> : TeacherBase<TSubject> where TSubject : ISubject
    {
        public MiddleSchoolTeacher(string name) : base(name)
        { }
    }
}
