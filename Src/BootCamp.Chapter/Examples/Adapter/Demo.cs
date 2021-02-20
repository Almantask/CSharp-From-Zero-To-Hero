using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Solution;
using BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.ThirdParty;
using BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Your;
using BootCamp.Chapter.Examples.Adapter.Problem.CompelxClass.Solution;
using BootCamp.Chapter.Examples.Adapter.Problem.CompelxClass.Ugly3rdPartyApi;

namespace BootCamp.Chapter.Examples.Adapter
{
    public class Demo
    {
        public static void Run()
        {
            var loggerToConsole = new Logger(new ConsoleWriter());
            loggerToConsole.Log(Logger.Level.Info, "Hello!");

            var loggerToAppInsights = new Logger(new ApplicationInsightsWriterAdapter(new ApplicationInsightsWriter()));
            loggerToAppInsights.Log(Logger.Level.Info, "Hello!");

            var writer = new Writer();
            var message = "";
            // YUCK!
            writer.WriterXYZabc123(ref message, out _);

            var cleanWriter = new PrettyWriter(writer);
            // Clean!
            cleanWriter.Write(message);
        }
    }
}
