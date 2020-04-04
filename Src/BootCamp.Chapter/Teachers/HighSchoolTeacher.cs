using BootCamp.Chapter.SchoolSubjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Teachers
{
    class HighSchoolTeacher : ITeacher<ISubject>
    {
        private ISubject _Teachings;

        public HighSchoolTeacher(ISubject subject)
        {
            _Teachings = subject;
        }

        public ISubject ProduceMaterial()
        {
            return _Teachings;
        }
    }
}
