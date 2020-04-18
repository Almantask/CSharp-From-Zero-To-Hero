using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    internal class CommandHandler
    {
        private static readonly string[] ValidCommands = new[]
        {
            "TIME"
        };

        private readonly string[] _commandText;
        private readonly FileInfo _outputFile;

        public CommandHandler(string[] commandText)
        {
            if (commandText is null)
            {
                throw new ArgumentNullException(nameof(commandText));
            }

            if (commandText.Any(x => string.IsNullOrEmpty(x)))
            {
                throw new ArgumentException("Unexpected empty or null argument.", nameof(commandText));
            }

            if (OutputFileArgumentProvided(commandText))
            {
                _outputFile = new FileInfo(commandText[1]);
            }

            _commandText = commandText[0].ToUpperInvariant().Split(' ');
        }

        private static bool OutputFileArgumentProvided(string[] commandText)
        {
            return commandText.Length == 2;
        }

        private bool CommandHasArgument() => _commandText.Length == 2;

        internal Action<Stream> ParseCommand()
        {
            string cmd = _commandText[0];

            if (!ValidCommands.Contains(cmd))
            {
                throw new InvalidCommandException();
            }

            if (cmd == "TIME")
            {
                string arg = null; 
                if (CommandHasArgument())
                {
                    arg = _commandText[1];
                    if(!Regex.IsMatch(arg, @"\d{2}:\d{2}-\d{2}:\d{2}"))
                    {
                        throw new InvalidCommandException();
                    }
                } 

                return new TimeCommand(_outputFile, arg).ExecuteCommand;
            }

            return null;
        }
    }
}
