using BootCamp.Chapter.Subjects;

namespace BootCamp.Chapter.Teachers
{
    public abstract class Teacher<TSubject> : ITeacher<TSubject> where TSubject : ISubject
    {
        public string Name { get; }
        public TSubject LatestLectureNote;

        protected Teacher(string name)
        {
            Name = name;
        }

        public void AddLectureNote(TSubject notes)
        {
            LatestLectureNote = notes;
        }

        public TSubject ProduceMaterial()
        {
            return LatestLectureNote;
        }
    }
}
