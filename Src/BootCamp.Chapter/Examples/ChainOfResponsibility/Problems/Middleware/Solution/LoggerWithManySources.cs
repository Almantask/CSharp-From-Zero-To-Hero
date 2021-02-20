using BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Problematic;

namespace BootCamp.Chapter.Examples.ChainOfResponsibility.Problems.Middleware.Solution
{
    public class LoggerWithManySources : ILogger
    {
        // The essence of pattern is to point to another possible step in the pipeline.
        private LoggerWithManySources _next;
        private readonly IWriter _loggingSource;

        public LoggerWithManySources(LoggerWithManySources next, IWriter loggingSource)
        {
            _next = next;
            _loggingSource = loggingSource;
        }

        public void Log(string message)
        {
            _loggingSource.Write(message);

            // Execute the next step in the pipeline if it exists.
            _next?.Log(message);
        }
    }
}
