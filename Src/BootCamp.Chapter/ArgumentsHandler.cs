using System;
using System.IO;

namespace BootCamp.Chapter
{
    internal class ArgumentsHandler
    {
        private const int MinimumArgumentCount = 2;
        private const int InputArgumentIndex = 0;
        private const int CommandArgumentIndex = 1;

        public static ArgumentsHandler Create(string[] args)
        {
            if (args.Length < MinimumArgumentCount)
            {
                throw new InvalidCommandException();
            }

            var inputFile = new FileInfo(args[InputArgumentIndex]);

            if (NonexistentOrEmptyFile(inputFile))
            {
                throw new NoTransactionsFoundException();
            }

            var parsedCommand = new CommandHandler(args[CommandArgumentIndex..]).ParseCommand();

            return new ArgumentsHandler(inputFile, parsedCommand);
        }

        private static bool NonexistentOrEmptyFile(FileInfo inputFile)
        {
            return !inputFile.Exists || inputFile.OpenText().ReadToEnd().Length == 0;
        }

        private readonly FileInfo _inputFile;
        private readonly Action<Stream> _command;

        private ArgumentsHandler(FileInfo inputFile, Action<Stream> command)
        {
            _inputFile = inputFile;
            _command = command;
        }

        public void Execute()
        {
            using var inputStream = _inputFile.OpenRead();
            _command(inputStream);
        }
    }
}
