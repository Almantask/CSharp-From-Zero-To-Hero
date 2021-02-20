using System;

namespace BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.ThirdParty
{
    // Code does not belong to us...
    // But we want to consume it.
    public class ApplicationInsightsWriter : IApplicationInsightsWriter
    {
        public void Write(string message)
        {
            // pretend it writes to app insights.
            Console.WriteLine("Writing to app insights");
            Console.WriteLine(message);
        }
    }
}
