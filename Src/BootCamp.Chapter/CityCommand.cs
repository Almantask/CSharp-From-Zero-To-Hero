using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    class CityCommand : ICommand, ICsvGenerator
    {
        private string[] _subCommands;
        private Dictionary<string, List<decimal>> _resultsOfCommand = new Dictionary<string, List<decimal>>();
        private Dictionary<string, int> _statMostItemsSold = new Dictionary<string, int>();
        private Dictionary<string, decimal> _statMostMoneyMade = new Dictionary<string, decimal>();
        private IOrderedEnumerable<KeyValuePair<string, decimal>> _outOrderedDict;

        public CityCommand(string command, string outputPath)
        {
            VerifyCommand(command);
        }

        // Implement the solution such tha depending on items or money, the correct csv file is generated.
        public void GenerateCsv(string outputPath)
        {
            try
            {
                int count = 0;
                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputPath}//city_command{_subCommands[0]}_{_subCommands[1]}.csv")))
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            writer.WriteLine($"Hour,Number of Items Sold,Average Money MadeHighest Grossing Hour?");
                            count++;
                        }
                        else
                        {
                            foreach (var  in _computedStats)
                            {
                                if (hour.Key == highestHour)
                                {
                                    writer.WriteLine($"{hour.Key},{hour.Value[0]},{hour.Value[1]},RushHour");
                                }
                                else
                                {
                                    writer.WriteLine($"{hour.Key},{hour.Value[0]},{hour.Value[1]}");
                                }
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        public void ExecuteCommand(TransactionDataParser transactionData)
        {
            List<Transaction> transactions = transactionData.Transactions;

            foreach (Transaction transaction in transactions)
            {
                UpdatingDictionary(transaction);
            }

            ComputeStats();
        }

        // Potentially can make this more 'DRY', seeming too much code which might be able to be simplified
        public void ComputeStats()
        {
            if (_subCommands[1] == "items")
            {
                foreach (var pair in _resultsOfCommand)
                {
                    _statMostItemsSold.Add(pair.Key, pair.Value.Count);
                }

                _outOrderedDict = _subCommands[0] == "max" ? _statMostMoneyMade.OrderByDescending(x => x.Value) : _statMostMoneyMade.OrderBy(x => x.Value);
            }
            else
            {
                foreach (var pair in _resultsOfCommand)
                {
                    _statMostMoneyMade.Add(pair.Key, pair.Value.Sum());
                }

                _outOrderedDict = _subCommands[0] == "max" ? _statMostMoneyMade.OrderByDescending(x => x.Value) : _statMostMoneyMade.OrderBy(x => x.Value);
            }
        }

        private void UpdatingDictionary(Transaction transaction)
        {
            string city = transaction.Location;
            if (!_resultsOfCommand.ContainsKey(city))
            {
                _resultsOfCommand.Add(city, new List<decimal>() { transaction.Price });
            }
            else
            {
                _resultsOfCommand[city].Add(transaction.Price);
            }
        }

        public void VerifyCommand(string inputCommand)
        {
            string[] splitCommand = inputCommand.Split(' ');

            string subCommand1 = VerifySubCommand1Legitimate(splitCommand[1].Trim('-'))
                ? splitCommand[1].Trim('-')
                : throw new ArgumentException($"{splitCommand[1]} is not valid. Either [\"-max\" or \"-min\"]");

            string subCommand2 = VerifySubCommand2Legitimate(splitCommand[2].Trim('-'))
                ? splitCommand[2].Trim('-')
                : throw new ArgumentException($"{splitCommand[2]} is not valid. Either [\"-items\" or \"-money\"]");

            _subCommands = new string[2]{subCommand1, subCommand2};
        }

        private bool VerifySubCommand1Legitimate(string subCommand)
        {
            Enum.TryParse(subCommand.ToUpper(), out CityCommands command);

            switch (command)
            {
                case CityCommands.MIN:
                    return true;

                case CityCommands.MAX:
                    return true;

                default:
                    return false;
            }
        }

        private bool VerifySubCommand2Legitimate(string subCommand)
        {
            Enum.TryParse(subCommand.ToUpper(), out CityCommands command);

            switch (command)
            {
                case CityCommands.ITEMS:
                    return true;

                case CityCommands.MONEY:
                    return true;

                default:
                    return false;
            }
        }

        
    }
}
