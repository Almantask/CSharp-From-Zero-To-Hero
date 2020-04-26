using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class CommandLine
    {
        public string InputFile { get; set; }
        public IEnumerable<string> Commands { get; set; }
        public string OutputFile { get; set; }

        private static readonly IList<string> allowedCommands = new List<string> { "time", "city", "items", "money", "full", "daily" };
        private static readonly IList<string> allowedOptions = new List<string> { "max", "min" };

        public static void TryParse(string[] args, out CommandLine commandLine)
        {
            commandLine = new CommandLine
            {
                InputFile = args.First(),
                OutputFile = args.Last(),
                Commands = args.Skip(1).SkipLast(1)
            };

            if (!commandLine.Commands.Any())
            {
                throw new InvalidCommandException();
            }

            if (!File.Exists(commandLine.InputFile))
            {
                throw new NoTransactionsFoundException($"{commandLine.InputFile} not found");
            }

            if (File.ReadAllLines(commandLine.InputFile).Length == 0)
            {
                throw new NoTransactionsFoundException($"{commandLine.InputFile} is empty");
            }

            var result = commandLine.Commands.Where(c => allowedCommands.Any(a => c.Contains(a.ToLower())));

            if (!result.Any())
            {
                throw new InvalidCommandException("no valid command arguments");
            }
            else
            {
                Console.WriteLine(commandLine.InputFile);
                Console.WriteLine(result.ToStringFormated(Csv.CsvDelimiter.Pipe));
                Console.WriteLine(commandLine.OutputFile);
            }
        }
    }
}

// TODO: better names for class members