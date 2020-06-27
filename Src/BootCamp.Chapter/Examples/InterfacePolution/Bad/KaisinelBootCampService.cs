namespace BootCamp.Chapter.Examples.InterfacePolution.Bad
{
    public class KaisinelBootCampService : IBootCampService
    {
        public Lesson GetLesson(int lesson)
        {
            // Implementation
            return new Lesson();
        }

        public void CreateLesson(Lesson lesson)
        {
            // Implementation
        }

        public void SignalStart(Lesson lesson)
        {
            // Implementation
        }

        public void Stream(Lesson lesson)
        {
            // Implementation
        }
    }
}