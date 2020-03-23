namespace BootCamp.Chapter.LogUtility
{
    enum Logger
    {
        Console,
        File
    }

    interface ILogger
    {
        void Log(string msg);
    }
}
