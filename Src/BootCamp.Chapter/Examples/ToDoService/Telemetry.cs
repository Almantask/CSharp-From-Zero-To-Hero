using System;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public class Telemetry
    {
        public string Context { get; }
        public DateTime Started { get; }
        public DateTime Ended { get; }
        public long ElapsedMs => (long)(Started - Ended).TotalMilliseconds;

        private Telemetry(string context, DateTime started, DateTime ended)
        {
            Context = context;
            Started = started;
            Ended = ended;
        }

        public Telemetry End()
            => new Telemetry(Context, Started, DateTime.Now);

        public static Telemetry Start(string context) 
            => new Telemetry(context, DateTime.Now, DateTime.Now);

        public override string ToString() => $"Context: {Context}, Elapsed: {ElapsedMs} ms";
    }
}