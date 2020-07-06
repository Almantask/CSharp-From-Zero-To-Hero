using BootCamp.Chapter.Demo;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // We instantiate our event subscriber.
            DemoApplication demoApplication = new DemoApplication();

            // We subscribe to events from the outside.
            demoApplication.ApplicationStateChanged += demoApplication.OnApplicationStateChange;
            demoApplication.InputWatcher.InputPressed += demoApplication.OnInputPressed;

            // We run our demo.
            demoApplication.Run();

            // We unsubscribe from events to allow them to be collected by the GC.
            demoApplication.ApplicationStateChanged -= demoApplication.OnApplicationStateChange;
            demoApplication.InputWatcher.InputPressed -= demoApplication.OnInputPressed;
        }
    }
}
