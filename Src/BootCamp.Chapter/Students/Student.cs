using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Students
{
    public abstract class Student : IStudent
    {
        public long Id { get; }
        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            throw new System.NotImplementedException();
        }
    }
}