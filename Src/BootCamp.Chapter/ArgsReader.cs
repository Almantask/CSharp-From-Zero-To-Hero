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
            ArgsChecksLength(args);
            string[] commandArr = ReadCommand(args[commandInt]);

            List<Transaction> transactions = ReportsManager.ReadTransaction(args[fileToReadInt]);

            ICommand command = default;

            switch (commandArr[0])
            {
                case timeCommand:
                    command = new TimeCommand();
                    break;

                case cityCommand:
                    command = new CityCommand();
                    break;
            }

            var toBeWritten = command.CreateReport(commandArr, transactions);
            command.WriteToCSV(args[fileToWriteInt], toBeWritten);
        }

        private static string[] ReadCommand(string command)
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

        private static void ArgsChecksLength(string[] args)
        {
            if (args == null || args.Length != 3)
            {
                throw new InvalidCommandException($"The {nameof(args)} must contain 1. The file path to read. 2. The command. 3. The file path to write.");
            }
        }
    }
}