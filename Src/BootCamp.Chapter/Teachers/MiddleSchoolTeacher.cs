using BootCamp.Chapter.Interface;
using System;

namespace BootCamp.Chapter.Teachers
{
    public class MiddleSchoolTeacher : ITeacher<ISubject>
    {
        ISubject subject;

        public MiddleSchoolTeacher(ISubject _subject)
        {
            subject = _subject;
        }

        public ISubject ProduceMaterial()
        {
            return subject;
        }

        public override string ToString()
        {
            return string.Format($"{subject} middleschoolteacher");
        }
    }
}
