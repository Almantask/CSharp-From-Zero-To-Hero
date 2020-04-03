using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Students
{
    class HighSchoolStudent : IStudent
    {
        public long Id => throw new NotImplementedException();

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            throw new NotImplementedException();
        }
    }
}
