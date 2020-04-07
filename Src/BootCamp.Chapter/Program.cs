namespace BootCamp.Chapter

{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var demo = new Demo();
            var appStatusNotifier = new AppStatusNotifier();

            Demo.AppStatusChanged += appStatusNotifier.OnAppStatusChanged;

            demo.Run();
        }
    }
}