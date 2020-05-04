using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public static class ArgsReader
    {
        private enum ArgsNumber
        {
            FileToRead,
            command,
            FileToWrite
        }

        //TODO finish ArgsReader
        /*
        You need to generate the following reports:

        By time (time)
        What city (can be parsed from address) earned the most/least money and what city sold the most/least items? (city [-min/-max] [-items/-money])
        --- Extra challenge:

        Daily money earned for specific shop. (daily Shop Name)

        What items were sold in what shop, at what price and when (file, named after shop). (full)

        Results should be printed to a file in .csv format.

        (3) and (4) supports sorting by shop name (or city name) in either ascending or descending order.
        If not sorting is provided, it should sort in ascending order. 
        Sorting is just 1 extra arg: -asc (sorts in ascending order by shop name); -desc (sorts in descending order by shop name)
        */

        const string timeCommand = "time";
        const string cityCommand = "city";
        public static void Read(string[] args)
        {
            ArgsChecksLength(args);
            List<Transaction> transactions = ReportsManager.ReadTransaction(args[(int)ArgsNumber.FileToRead]);
            string[] command = ReadCommand(args[(int)ArgsNumber.command]);

            switch (command[0])
            {
                case timeCommand:
                    RunTimeCommand(command, transactions);
                    break;
                case cityCommand:
                    RunCityCommand(command, transactions);
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
                    return(splitCommand);
                case cityCommand:
                    return(splitCommand);
                default:
                    throw new InvalidCommandException($"{splitCommand[0]} is not a valid command.");
            }

        }

        private static void RunTimeCommand(string[] command, List<Transaction> transactions)
        {
            //TODO RunTimeCommand
            /*
            By time(time)
            how many items have been bought during every hour of time of day,
            how much money did every hour total(on average),
            and get rush hour(most mony earned on average).
            Support getting items sold count and money earned for a selected range of hours as well.
            */
            //"time 11:00-17:00"
            if (command.Length == 1)
            {
                Time(transactions);
            }
            else if (command.Length == 2)
            {
                if(IsHoursCorrect(command[1], out DateTime[] times))
                {
                    Time(transactions, times);
                }
            }
            else
            {
                throw new InvalidCommandException($"{command[0]} has to many parameters.");
            }

        }

        private static bool IsHoursCorrect(string hours, out DateTime[] times)
        {
            //TODO IsHoursCorrect()
            throw new NotImplementedException();
        }

        private static void Time(List<Transaction> transactions)
        {
            const string topRow = "Hour, Count, Earned";

            var soldByTime = transactions.GroupBy(t => t.DateTime.Hour);
            Console.WriteLine(soldByTime);

            //TODO finish Time FIRTST!!!!!


        }
        private static void Time(List<Transaction> transactions, DateTime[] times)
        {

        }
        private static void RunCityCommand(string[] command, List<Transaction> transactions)
        {
            //TODO RunCityCommand
            //What city(can be parsed from address) earned the most / least money and what city sold the most / least items ? (city[-min / -max][-items / -money])

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
