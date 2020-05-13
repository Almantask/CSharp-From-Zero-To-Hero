using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        /*
        What city (can be parsed from address) earned the most/least money and what city sold the most/least items? (city [-min/-max] [-items/-money])
        --- Extra challenge:

        Daily money earned for specific shop. (daily Shop Name)

        What items were sold in what shop, at what price and when (file, named after shop). (full)

        Results should be printed to a file in .csv format.

        (3) and (4) supports sorting by shop name (or city name) in either ascending or descending order.
        If not sorting is provided, it should sort in ascending order. 
        Sorting is just 1 extra arg: -asc (sorts in ascending order by shop name); -desc (sorts in descending order by shop name)
        */

        private const string timeCommand = "time";
        private const string cityCommand = "city";
        const int fileToRead = 0;
        const int command = 1;
        const int fileToWrite = 2;
        public static void Read(string[] args)
        {
            ArgsChecksLength(args);
            List<Transaction> transactions = ReportsManager.ReadTransaction(args[fileToRead]);
            string[] commandArr = ReadCommand(args[command]);
            IEnumerable<String> toBeWritten = default;

            switch (commandArr[0])
            {
                case timeCommand:
                    toBeWritten = Command.CreateTimeReport(commandArr, transactions);
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

            //Trim all the Strings
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
