using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Example.NotDip.JustCodingToAnInterface
{
    public class DummyService : IDummyService
    {
        // It's an interface
        // But it's a third party abstraction
        // We're still coupled with implementation-specific abstraction
        // that does not belong to us.
        private readonly Serilog.ILogger _logger;

        public DummyService(Serilog.ILogger logger)
        {
            _logger = logger;
        }

        public void DoDummyThings(Serilog.ILogger logger)
        {
            _logger.Information("Doing dummy things");
            Console.WriteLine("Eh?");
            _logger.Information("Done doing silly things");
        }
    }

    public interface IDummyService
    {
    }
}
