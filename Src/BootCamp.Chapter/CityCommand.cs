using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class CityCommand : ICommand
    {
        public IEnumerable<string> CreateReport(string[] command, List<Transaction> transactions)
        {
            const string money = "-money";
            const string items = "-items";
            const string min = "-min";
            const string max = "-max";

            if (command.Length != 3)
            {
                throw new InvalidCommandException($"{command[0]} has the wrong amount of parameters.");
            }

            if (command[1] == items)
            {
                if (command[2] == min || command[2] == max)
                {
                    return FindItemsMaxOrMin(transactions, command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{command[2]} is not a valid parameter.");
                }
            }
            else if (command[1] == money)
            {
                if (command[2] == min || command[2] == max)
                {
                    return FindMoneyMaxOrMin(transactions, command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{command[2]} is not a valid parameter.");
                }
            }
            else
            {
                throw new InvalidCommandException($"{command[1]} is not a valid parameter.");
            }
        }

        private static IEnumerable<String> FindMoneyMaxOrMin(List<Transaction> transactions, string maxOrMin)
        {
            /*
            var groupedcity = from i in transactions
                              group i by i.City into g
                              select new { g.Key, Total = g.Sum(i => i.Price) };

            */
            var groupedcity = transactions.GroupBy(i => i.City)
                                          .Select(g => new { g.Key, Total = g.Sum(i => i.Price) });

            decimal itemsPerCityMaxOrMin = maxOrMin == "-max" ? groupedcity.Max(g => g.Total) : groupedcity.Min(g => g.Total);

            var toReturn = from i in groupedcity
                           where i.Total == itemsPerCityMaxOrMin
                           select i.Key.Trim();
            return toReturn;
        }

        private static IEnumerable<String> FindItemsMaxOrMin(List<Transaction> transactions, string maxOrMin)
        {
            var groupedcity = from i in transactions
                              group i.City by i.City into g
                              select new { g.Key, Count = g.Count() };

            int itemsPerCityMaxOrMin = maxOrMin == "-max" ? groupedcity.Max(g => g.Count) : groupedcity.Min(g => g.Count);

            var toReturn = from i in groupedcity
                           where i.Count == itemsPerCityMaxOrMin
                           select i.Key.Trim();
            return toReturn;
        }

        public void WriteToCSV(string path, IEnumerable<string> toBeWritten)
        {
            ReportsManager.WriteCityTransaction(path, toBeWritten);
        }
    }
}