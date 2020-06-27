namespace BootCamp.Chapter.Examples.InterfacePolution.Good
{
    public class TimCoreyBootCampService : ITimCoeryBootCampService
    {
        public Lesson GetLesson(int lesson)
        {
            // Implementation...
            return new Lesson();
        }
        public void CreateLesson(Lesson lesson)
        {
            // Implementation...
        }
    }
}