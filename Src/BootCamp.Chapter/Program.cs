using BootCamp.Chapter.ApplicationState;
using BootCamp.Chapter.Demo;
using BootCamp.Chapter.UserInput;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // We instantiate our event publishers.
            ApplicationStateController applicationStateController = new ApplicationStateController();
            InputWatcher consoleInputWatcher = new InputWatcher();

            // We instantiate our event subscriber.
            DemoApplication demoApplication = new DemoApplication();

            // We subscribe to events.
            applicationStateController.ApplicationStateChanged += demoApplication.OnApplicationStateChange;
            consoleInputWatcher.InputPressed += demoApplication.OnInputPressed;

            // We run our demo.
            demoApplication.Run();

            // We unsubscribe from events.
            applicationStateController.ApplicationStateChanged -= demoApplication.OnApplicationStateChange;
            consoleInputWatcher.InputPressed -= demoApplication.OnInputPressed;
        }
    }
}
