using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        private const string timeCommand = "time";
        private const string cityCommand = "city";
        private const int fileToReadInt = 0;
        private const int commandInt = 1;
        private const int fileToWriteInt = 2;

        public static void Read(string[] args)
        {
            CheckArgsLength(args);
            string[] commandArr = ReadAndCheckCommand(args[commandInt]);

            List<Transaction> transactions = ReportsManager.ReadTransactionFile(args[fileToReadInt]);

            ICommand command = default;

            switch (commandArr[0])
            {
                case timeCommand:
                    command = new TimeCommand(args[fileToWriteInt], commandArr, transactions);
                    break;

                case cityCommand:
                    command = new CityCommand(args[fileToWriteInt], commandArr, transactions);
                    break;
            }

            command.Execute();
        }

        private static string[] ReadAndCheckCommand(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new InvalidCommandException($"Please give a valid command.");
            }

            string[] splitCommand = command.Split(' ');

            for (int i = 0; i < splitCommand.Length; i++)
            {
                splitCommand[i] = splitCommand[i].Trim();
            }

            switch (splitCommand[0])
            {
                case timeCommand:
                    return (splitCommand);

                case cityCommand:
                    return (splitCommand);

                default:
                    throw new InvalidCommandException($"{splitCommand[0]} is not a valid command.");
            }
        }

        private static void CheckArgsLength(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                throw new InvalidCommandException($"The {nameof(args)} must contain 1. The file path to read. 2. The command. 3. The file path to write.");
            }
        }
    }
}