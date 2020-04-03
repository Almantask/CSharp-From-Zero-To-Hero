using BootCamp.Chapter.SchoolSubjects;
using BootCamp.Chapter.Teachers;

namespace BootCamp.Chapter.Students
{
    interface IStudent
    {
        // has a list of materials learnt.
        long Id { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher) where TTeacher : ITeacher<TSubject> where TSubject : ISubject;
    }
}
