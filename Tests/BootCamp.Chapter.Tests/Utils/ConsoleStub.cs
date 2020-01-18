using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Tests.Utils
{
    public static class ConsoleStub
    {
        public static StringWriter StubConsole(string readLineReturn)
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(readLineReturn);
            Console.SetIn(input);

            return output;
        }
    }
}
