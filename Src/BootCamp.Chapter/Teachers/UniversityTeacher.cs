using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    class UniversityTeacher<TSubject> : TeacherBase<TSubject> where TSubject : ISubject
    {
        public UniversityTeacher(string name) : base(name)
        {
        }
    }
}
