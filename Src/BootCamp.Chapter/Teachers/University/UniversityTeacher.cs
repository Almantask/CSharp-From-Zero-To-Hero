namespace BootCamp.Chapter.Teachers
{
    public abstract class UniversityTeacher : Teacher<Subject>
    {
        public abstract override Subject ProduceSubjectMaterial();
    }
}