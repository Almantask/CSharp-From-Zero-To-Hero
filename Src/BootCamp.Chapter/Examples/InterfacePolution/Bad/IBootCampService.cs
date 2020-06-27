namespace BootCamp.Chapter.Examples.InterfacePolution.Bad
{
    public interface IBootCampService
    {
        Lesson GetLesson(int lesson);
        void CreateLesson(Lesson lesson);
        void SignalStart(Lesson lesson);
        void Stream(Lesson lesson);
    }
}
