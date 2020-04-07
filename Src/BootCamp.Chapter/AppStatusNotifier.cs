using LogLibrary;

namespace BootCamp.Chapter

{
    public class AppStatusNotifier
    {
        public void OnAppStatusChanged(object sender, DemoAppEventArgs args)
        {
            Logger.SetTarget(LogTarget.File);
            Logger.LogEvent(args.AppStatus.ToString());
        }
    }
}