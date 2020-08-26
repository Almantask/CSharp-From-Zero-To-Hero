using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.ToDoService
{
    public interface ITelemetryTracker
    {
        void Start(string context);
        Telemetry Stop();
    }
}
