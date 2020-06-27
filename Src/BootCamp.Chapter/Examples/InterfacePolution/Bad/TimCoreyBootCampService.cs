namespace BootCamp.Chapter.Examples.InterfacePolution.Bad
{
    class TimCoreyBootCampService : IBootCampService
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

        public void SignalStart(Lesson lesson)
        {
            // No notifications prior to lessons.
            throw new System.NotImplementedException();
        }

        public void Stream(Lesson lesson)
        {
            // No live streams.
            throw new System.NotImplementedException();
        }
    }
}