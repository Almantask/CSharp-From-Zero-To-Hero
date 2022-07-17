namespace BootCamp.Chapter
{
    public interface ILogger
    {
        void Error(string error);
        void Message(string message);
        void Boot();
        void Shutdown();
    }
}