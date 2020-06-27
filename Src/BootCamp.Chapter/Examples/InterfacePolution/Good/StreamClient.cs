using System.Linq.Expressions;

namespace BootCamp.Chapter.Examples.InterfacePolution.Good
{
    public static class Demo
    {
        public static void Run()
        {
            var kaisinelBootCamp = new KaisinelBootCampService();
            var client = new StreamClient(kaisinelBootCamp, kaisinelBootCamp);
            client.Stream(new Lesson());
        }
    }

    public class StreamClient
    {
        private readonly ILessonStreamer _streamer;
        private readonly ILessonNotifier _notifier;

        public StreamClient(ILessonStreamer streamer, ILessonNotifier notifier)
        {
            _streamer = streamer;
            _notifier = notifier;
        }

        public void Stream(Lesson lesson)
        {
            _streamer.Stream(lesson);
            _notifier.SignalStart(lesson);
        }
    }
}
