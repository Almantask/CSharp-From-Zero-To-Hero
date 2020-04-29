using BootCamp.Chapter.Subjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Students
{
    public interface IStudent
    {
        long Id { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }
}