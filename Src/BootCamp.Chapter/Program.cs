using System.Reflection;
namespace BootCamp.Chapter
{
    class Program
    {
        static void Main()
        {
            // Instanstiates the InputMonitor class
            InputMonitor inputMonitor = new InputMonitor();

            // Instantiates the ApplicationController class
            ApplicationController applicationController = new ApplicationController(inputMonitor);

            // Subscriptions to ApplicationModeChanged Event outside of where it is handled
            applicationController.ApplicationModeChanged += applicationController.OnApplicationModeChange;
            applicationController.ApplicationModeChanged += applicationController.OnCloseApplicationRequest;

            // Subscription to InputPressed Event outside of where it is handled
            inputMonitor.InputPressed += applicationController.OnInputPressed;
            

            applicationController.Run();
        }
    }
}
