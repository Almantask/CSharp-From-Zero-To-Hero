namespace BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Problematic
{
    public class Logger : ILogger
    {
        // Our logger should log anywhere
        // In fact it should logging to different sources simultanously.

        // Only one logging source is supported.
        private readonly IWriter _loggingSource;

        public void Log(string message)
        {
            _loggingSource.Write(message);
        }
    }
}
