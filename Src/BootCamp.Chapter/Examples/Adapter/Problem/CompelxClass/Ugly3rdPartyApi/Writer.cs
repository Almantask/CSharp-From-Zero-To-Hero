using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Examples.Adapter.Problem.CompelxClass.Ugly3rdPartyApi
{
    public class Writer
    {
        // Sometimes the apis we use are like this.
        // Underdesigned, with an ugly api
        // Sometimes, with features that are niche and we don't need ever.
        // Yet it complicates things...
        public void WriterXYZabc123(ref string message, out bool wasWritten)
        {
            // does something more neat.
            Console.WriteLine(message);
            wasWritten = true;
        }
    }
}
