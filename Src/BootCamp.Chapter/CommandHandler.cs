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
            "TIME",
            "CITY", 
            "DAILY"
        };

        private readonly CommandArgument[] _commandText;
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

            _commandText = commandText[0].Split(' ').Select(x => new CommandArgument(x)).ToArray();
        }

        private static bool OutputFileArgumentProvided(string[] commandText)
        {
            return commandText.Length == 2;
        }

        private bool CommandHasArguments() => _commandText.Length >= 2;

        internal Action<Stream> ParseCommand()
        {
            var cmd = _commandText[0].NormalizedArgument;

            if (!ValidCommands.Contains(cmd))
            {
                throw new InvalidCommandException();
            }

            if (cmd == "CITY")
            {
                var cityArguments = new[] { "CITY", "-MIN", "-MAX", "-MONEY", "-ITEMS" };

                if (_commandText.Select(x => x.NormalizedArgument).Intersect(cityArguments).Count() != 3)
                {
                    throw new InvalidCommandException(); 
                }

                var command = new CityCommand(_outputFile, _commandText[1].NormalizedArgument, _commandText[2].NormalizedArgument);
                return command.ExecuteCommand;
            }

            if (cmd == "TIME")
            {
                CommandArgument arg = null; 
                if (CommandHasArguments())
                {
                    arg = _commandText[1];
                    if(!Regex.IsMatch(arg.Argument, @"\d{2}:\d{2}-\d{2}:\d{2}"))
                    {
                        throw new InvalidCommandException();
                    }
                } 

                return new TimeCommand(_outputFile, arg).ExecuteCommand;
            }

            if (cmd == "DAILY")
            {
                if (!CommandHasArguments())
                {
                    throw new InvalidCommandException();
                }

                var shopName = string.Join(" ", _commandText[1..].Select(x => x.Argument));

                return new DailyCommand(_outputFile, shopName).ExecuteCommand;
                //var arg = new CommandArgument(_commandText[1])
            }

            return null;
        }
    }
}
