using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public abstract class Teacher<TSubject> : ITeacher<TSubject> where TSubject : ISubject
    {
        public TSubject ProduceMaterial()
        {
            throw new System.NotImplementedException();
        }
    }
}