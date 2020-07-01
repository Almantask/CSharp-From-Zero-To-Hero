using BootCamp.Chapter.Subjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class UniversityTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public UniversityTeacher(string name, TSubject subjectTaught) : base(name, subjectTaught) { }
    }
}
