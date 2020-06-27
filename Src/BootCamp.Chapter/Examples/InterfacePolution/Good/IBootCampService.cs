namespace BootCamp.Chapter.Examples.InterfacePolution.Good
{
    public interface IKaisinelBootCampService : ILessonStore, ILessonStreamer, ILessonNotifier
    {
    }

    public interface ITimCoeryBootCampService : ILessonStore    
    {
    }

    public interface ILessonStore
    {
        Lesson GetLesson(int lesson);
        void CreateLesson(Lesson lesson);
    }

    public interface ILessonNotifier
    {
        void SignalStart(Lesson lesson);
    }

    public interface ILessonStreamer
    {
        void Stream(Lesson lesson);
    }
}
