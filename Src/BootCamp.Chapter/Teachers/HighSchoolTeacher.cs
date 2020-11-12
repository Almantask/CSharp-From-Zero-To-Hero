using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Teachers
{
    public class HighSchoolTeacher : ITeacher<ISubject>
    {
        ISubject subject;

        public HighSchoolTeacher(ISubject _subject)
        {
            subject = _subject;
        }

        public ISubject ProduceMaterial()
        {
            return subject;
        }

        public override string ToString()
        {
            return string.Format($"{subject} highschoolteacher");
        }
    }
}
