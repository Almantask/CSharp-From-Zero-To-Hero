using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public interface ITeacher<TSubject> where TSubject: ISubject
    {
        public string Name { get; }    
        TSubject produceMetarial();
    }
}
