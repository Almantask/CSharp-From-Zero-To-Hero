using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter.Tests.Utils
{
    public static class FakeConsole
    {
        public const string TestFileExtension = "consoleStub";

        public static StringWriter Initialize(string readLineReturn)
        {
            var output = new StringWriter();
            Console.SetOut(output);

            var input = new StringReader(readLineReturn);
            Console.SetIn(input);

            return output;
        }

        /// <summary>
        /// Fakes console output to write to a file called {testKey}.consoleStub
        /// Stubs out console input.
        /// </summary>
        public static StreamWriter Initialize(string readLineReturn, string testKey)
        {
            var output = new StreamWriter($"{testKey}.{TestFileExtension}");
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
            var output = File.ReadAllText($"{testKey}.{TestFileExtension}");

            return output;
        }

        /// <summary>
        /// To be used only if <see cref="StreamWriter"/> for stub console was used.
        /// Deletes the file for console using testKey.
        /// </summary>
        public static void Cleanup(string testKey)
        {
            File.Delete($"{testKey}.{TestFileExtension}");
        }
    }
}
