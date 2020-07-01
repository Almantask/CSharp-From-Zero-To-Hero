using BootCamp.Chapter.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public HighSchoolTeacher(string name, TSubject subjectTaught) : base(name, subjectTaught) { }
    }
}
