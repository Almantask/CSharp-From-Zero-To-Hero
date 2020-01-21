using System;
using System.IO;
using BootCamp.Chapter.Tests.Utils;

namespace BootCamp.Chapter.Tests
{
    public class ConsoleTests: IDisposable
    {
        /// <summary>
        /// Disposes console output file and returns its' contents.
        /// </summary>
        protected string ConsoleOutput
        {
            get
            {
                if (_consoleOutput == null)
                {
                    throw new ArgumentNullException(nameof(_consoleOutput));
                }

                _consoleOutput.Dispose();
                var content = ConsoleStub.ReadAllText(_testKey);

                return content;
            }
        }

        /// <summary>
        /// Stubs <see cref="Console.ReadLine()"/> and <see cref="Console.WriteLine()"/>.
        /// ReadLine will be the value set and writes will go to file.
        /// </summary>
        protected string ConsoleInput
        {
            set
            {
                _testKey = Guid.NewGuid().ToString();
                _consoleOutput = ConsoleStub.StubConsole(value, _testKey);
            }
        }

        /// <summary>
        /// Stubs out <see cref="Console.WriteLine()"/>
        /// Console output goes to file.
        /// </summary>
        protected void StubConsoleOutput()
        {
            _testKey = Guid.NewGuid().ToString();
            var output = new StreamWriter($"{_testKey}.{ConsoleStub.TestFileExtension}");
            Console.SetOut(output);
        }

        private const string PromptMessage = "Testing";
        private string _testKey;
        private StreamWriter _consoleOutput;

        public void Dispose()
        {
            if (_testKey == null) return;

            ConsoleStub.Cleanup(_testKey);
        }
    }
}
