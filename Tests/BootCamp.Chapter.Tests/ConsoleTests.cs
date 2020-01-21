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
                var content = FakeConsole.ReadAllText(_testKey);

                return content;
            }
        }

        /// <summary>
        /// Stubs <see cref="Console.ReadLine()"/> and fakes <see cref="Console.WriteLine()"/>.
        /// ReadLine will be the value set and writes will be redirected to file.
        /// </summary>
        protected string ConsoleInput
        {
            set
            {
                _testKey = Guid.NewGuid().ToString();
                _consoleOutput = FakeConsole.Initialize(value, _testKey);
            }
        }

        /// <summary>
        /// Fakes <see cref="Console.WriteLine()"/>.
        /// Console output goes to file.
        /// </summary>
        protected void RedirectConsoleToFile()
        {
            _testKey = Guid.NewGuid().ToString();
            _consoleOutput = new StreamWriter($"{_testKey}.{FakeConsole.TestFileExtension}");
            Console.SetOut(_consoleOutput);
        }

        /// <summary>
        /// Used for identifying test file for the current test case console redirected output.
        /// </summary>
        private string _testKey;
        private StreamWriter _consoleOutput;

        public void Dispose()
        {
            if (_testKey != null)
            {
                _consoleOutput.Dispose();
                FakeConsole.Cleanup(_testKey);
            }
        }
    }
}
