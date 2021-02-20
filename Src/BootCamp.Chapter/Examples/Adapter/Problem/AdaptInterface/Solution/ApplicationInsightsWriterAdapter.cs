using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.ThirdParty;
using BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Your;

namespace BootCamp.Chapter.Examples.Adapter.Problem.AdaptInterface.Solution
{
    public class ApplicationInsightsWriterAdapter : IWriter
    {
        // We encapsulate the appinsightswriter
        // And the class which encapsulates it- implements the interface we need- IWriter.
        // This way, the only missing thing we need to do- is to convert the input/output formats so it conforms to our own interface.
        private IApplicationInsightsWriter _appinsightsWriter;

        // The thing we adapt is injected
        public ApplicationInsightsWriterAdapter(IApplicationInsightsWriter appinsightsWriter)
        {
            _appinsightsWriter = appinsightsWriter;
        }

        // And we just expose minimum behavior needed, which comes from the adaptee.
        public void Write(string message) => _appinsightsWriter.Write(message);
    }
}
