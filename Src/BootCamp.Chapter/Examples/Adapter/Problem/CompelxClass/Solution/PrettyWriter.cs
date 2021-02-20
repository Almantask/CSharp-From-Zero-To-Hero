using System;
using System.Collections.Generic;
using System.Text;
using BootCamp.Chapter.Examples.Adapter.Problem.CompelxClass.Ugly3rdPartyApi;

namespace BootCamp.Chapter.Examples.Adapter.Problem.CompelxClass.Solution
{
    // Instead of consuming an ugly api
    // We can adapt and consume it in a convenient way for us.
    public class PrettyWriter
    {
        private readonly Writer _writer;

        public PrettyWriter(Writer writer)
        {
            _writer = writer;
        }

        // we can use this method- simple
        public void Write(string message)
        {
            // instead of using this method - complex
            _writer.WriterXYZabc123(ref message, out _);
        }
    }
}
