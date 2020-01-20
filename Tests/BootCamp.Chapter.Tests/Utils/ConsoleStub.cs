using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Tests.Utils
{
    public static class ConsoleStub
    {
        private const string testFileExtension = "consoleStub";

        public static StringWriter StubConsole(string readLineReturn)
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(readLineReturn);
            Console.SetIn(input);

            return output;
        }

        /// <summary>
        /// Writes console output to a file called {testKey}.consoleStub
        /// </summary>
        public static StreamWriter StubConsole(string readLineReturn, string testKey)
        {
            var output = new StreamWriter($"{testKey}.{testFileExtension}");
            Console.SetOut(output);

            var input = new StringReader(readLineReturn);
            Console.SetIn(input);

            return output;
        }

        /// <summary>
        /// To be used only if <see cref="StreamWriter"/> for stub console was used.
        /// Read file of console input by testKey.
        /// </summary>
        public static string ReadAllText(string testKey)
        {
            var output = File.ReadAllText($"{testKey}.{testFileExtension}");

            return output;
        }

        /// <summary>
        /// To be used only if <see cref="StreamWriter"/> for stub console was used.
        /// Deletes the file for console using testKey.
        /// </summary>
        public static void Cleanup(string testKey)
        {
            File.Delete($"{testKey}.{testFileExtension}");
        }
    }
}
