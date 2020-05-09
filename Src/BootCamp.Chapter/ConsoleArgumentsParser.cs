using System;
using System.IO;

namespace BootCamp.Chapter
{
    public static class ConsoleArgumentsParser
    {
        public static void ArgumentsParser(string[] args)
        {
            var inputFile = args[0];

            if (args.Length != 3)
            {
                throw new InvalidCommandException();
            }

            if (!File.Exists(inputFile))
            {
                throw new NoTransactionsFoundException();
            }

            var parser = new TransactionJsonParser(@$"{inputFile}");

            if (parser.Transactions.Count == 0)
            {
                throw new NoTransactionsFoundException();
            }

            var splittedCommands = args[1].Split(' ');

            if (splittedCommands[0] != "city" && splittedCommands[0] != "time")
            {
                throw new InvalidCommandException();
            }

            if (splittedCommands[0] == "time")
            {
                var beginTime = new TimeSpan(0, 0, 0);
                var endTime = new TimeSpan(23, 59, 59);

                if (splittedCommands.Length != 1)
                {
                    //var time = splittedCommands[1].Split('-');
                    beginTime = TimeSpan.Parse(splittedCommands[1]);
                    endTime = TimeSpan.Parse(splittedCommands[3]);
                }

                var outcome = TimeStatics.CalculateTimeReport(parser.Transactions, beginTime, endTime);
            }

            if (args[1] == "city -money -min")
            {
                var outcome = ShopStatistics.FindCityWithLowestSales(parser.Transactions);
            }

            if (args[1] == "city -money -max")
            {
                var outcome = ShopStatistics.FindCityWithHighestSales(parser.Transactions);
            }

            if (args[1] == "city -items -max")
            {
                var outcome = ShopStatistics.FindCityWithHighestSoldItems(parser.Transactions);
            }

            if (args[1] == "city -items -min")
            {
                var outcome = ShopStatistics.FindCityWithLowestSoldItems(parser.Transactions);
            }
        }
    }
}
