using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher<TSubject> : TeacherBase<TSubject> where TSubject : ISubject
    {
        public HighSchoolTeacher(string name) : base(name)
        { }
    }
}
