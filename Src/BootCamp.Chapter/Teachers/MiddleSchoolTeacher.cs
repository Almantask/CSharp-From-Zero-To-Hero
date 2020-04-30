using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public class MiddleSchoolTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public MiddleSchoolTeacher(string name) : base(name)
        {
        }
    }
}