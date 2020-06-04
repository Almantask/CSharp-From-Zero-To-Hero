using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public class HighSchoolTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public HighSchoolTeacher(string name, TSubject subjectTaught) : base (name, subjectTaught) { }
    }
}
