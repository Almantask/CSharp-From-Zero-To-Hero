namespace BootCamp.Chapter.Examples.AdaptingThirdParty._3rdParty
{
    public interface IBootCampService
    {
        Lesson GetLesson(int lesson);
        void CreateLesson(Lesson lesson);
        void SignalStart(Lesson lesson);
        void Stream(Lesson lesson);
    }
}
