namespace BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Your
{
    public class Logger
    {
        public enum Level
        {
            Info,
            Warning,
            Error
        }

        private readonly IWriter _writer;

        // We want our logger to write to a console
        // Or to app insights.
        // App insights however come from another assembly which does not belong to us.
        // We cannot touch that code as it isn't ours.
        public Logger(IWriter writer)
        {
            _writer = writer;
        }

        public void Log(Level level, string message)
        {
            _writer.Write($"{level,-7} - {message}");
        }
    }
}
