using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        private const string timeCommand = "time";
        private const string cityCommand = "city";
        private const int fileToRead = 0;
        private const int command = 1;
        private const int fileToWrite = 2;

        public static void Read(string[] args)
        {
            ArgsChecksLength(args);
            string[] commandArr = ReadCommand(args[command]);

            List<Transaction> transactions = ReportsManager.ReadTransaction(args[fileToRead]);

            switch (commandArr[0])
            {
                case timeCommand:
                    var toBeWritten = Command.CreateTimeReport(commandArr, transactions);
                    ReportsManager.WriteTimeTransaction(args[fileToWrite], toBeWritten);
                    break;

                case cityCommand:
                    toBeWritten = Command.CreateCityReport(commandArr, transactions);
                    ReportsManager.WriteCityTransaction(args[fileToWrite], toBeWritten);
                    break;
            }
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