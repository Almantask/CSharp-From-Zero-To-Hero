using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public class UniversityTeacher<TSubject> : Teacher<TSubject> where TSubject : ISubject
    {
        public UniversityTeacher(string name) : base(name)
        {
        }
    }
}
