using System;
using System.Collections.Generic;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class CityCommand : ICommand
    {
        private string _Path;
        private string[] _Command;
        private List<Transaction> _Transactions;

        public CityCommand(string path, string[] command, List<Transaction> transactions)
        {
            _Path = path;
            _Command = command;
            _Transactions = transactions;
        }

        public void Execute()
        {
            var toBeWritten = CreateReport();
            WriteToCSV(toBeWritten);
        }
        private IEnumerable<string> CreateReport()
        {
            const string money = "-money";
            const string items = "-items";
            const string min = "-min";
            const string max = "-max";

            if (_Command.Length != 3)
            {
                throw new InvalidCommandException($"{_Command[0]} has the wrong amount of parameters.");
            }

            if (_Command[1] == items)
            {
                if (_Command[2] == min || _Command[2] == max)
                {
                    return FindItemsMaxOrMin(_Transactions, _Command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{_Command[2]} is not a valid parameter.");
                }
            }
            else if (_Command[1] == money)
            {
                if (_Command[2] == min || _Command[2] == max)
                {
                    return FindMoneyMaxOrMin(_Transactions, _Command[2]);
                }
                else
                {
                    throw new InvalidCommandException($"{_Command[2]} is not a valid parameter.");
                }
            }
            else
            {
                throw new InvalidCommandException($"{_Command[1]} is not a valid parameter.");
            }
        }

        private static IEnumerable<String> FindMoneyMaxOrMin(List<Transaction> transactions, string maxOrMin)
        {
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

        private void WriteToCSV(IEnumerable<string> toBeWritten)
        {
            ReportsManager.WriteCityTransaction(_Path, toBeWritten);
        }
    }
}