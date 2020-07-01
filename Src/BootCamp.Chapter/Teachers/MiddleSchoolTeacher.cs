using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class MiddleSchoolTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public MiddleSchoolTeacher(string name, TSubject subjectTaught) : base(name, subjectTaught) { }
    }
}
