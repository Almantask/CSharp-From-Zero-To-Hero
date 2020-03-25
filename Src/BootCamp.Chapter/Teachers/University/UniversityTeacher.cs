namespace BootCamp.Chapter.Teachers
{
    internal abstract class UniversityTeacher : Teacher<Subject>
    {
        public abstract override Subject ProduceSubjectMaterial();
    }
}