using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public interface ITeacher<out TSubject> where TSubject : ISubject // We use "out" to apply covariance (so we can store something specific in something general).
    {
        TSubject ProduceMaterial(); // Thanks to covariance, we can store whatever's returned here in a more "general" type/form i.e. ISubject.
    }
}
