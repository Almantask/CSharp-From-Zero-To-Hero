using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public interface ITeacher<out TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
}