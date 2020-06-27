using Good = BootCamp.Chapter.Examples.InterfacePolution.Good;
using ThirdParty = BootCamp.Chapter.Examples.AdaptingThirdParty._3rdParty;

namespace BootCamp.Chapter.Examples.AdaptingThirdParty
{
    public static class Demo
    {
        public static void Run()
        {
            var bootcampService = new ThirdParty.KaisinelBootCampService();
            var lessonStreamer = new KaisinelLessonStreamAdapter(bootcampService);
            var lessonNotifier = new KaisinelLessonSignalStartAdapter(bootcampService);

            var client = new BootCampClient(lessonStreamer, lessonNotifier);
            client.Stream(new Good.Lesson());
        }
    }

    public class BootCampClient
    {
        private readonly Good.ILessonStreamer _streamer;
        private readonly Good.ILessonNotifier _notifier;

        public BootCampClient(Good.ILessonStreamer streamer, Good.ILessonNotifier notifier)
        {
            _streamer = streamer;
            _notifier = notifier;
        }

        public void Stream(Good.Lesson lesson)
        {
            _streamer.Stream(lesson);
            _notifier.SignalStart(lesson);
        }
    }
}
