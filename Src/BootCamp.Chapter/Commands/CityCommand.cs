using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter.Commands
{
    class CityCommand : Command
    {
        public readonly string _inputCommand;
        private string[] _subCommands;
        private Dictionary<string, List<decimal>> _tempDictionary = new Dictionary<string, List<decimal>>();
        private Dictionary<string, decimal> _statisticsDictionary = new Dictionary<string, decimal>();
        private Dictionary<string, decimal> _resultsOfCommand;
        private readonly string _outputPath;

        public CityCommand(string inputCommand, string outputPath)
        {
            _inputCommand = inputCommand;
            _outputPath = outputPath;
            VerifyCommand(_inputCommand);

            CsvGenerator<CityCommand> csvGenerator = new CsvGenerator<CityCommand>(_outputPath, this);
            csvGenerator.GenerateCsvCity();
        }

        public void GenerateCsv(string outputPath)
        {
            try
            {
                Console.WriteLine($"Generating .csv file: [{_inputCommand}]");
                int count = 0;
                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputPath}//City{_subCommands[0]}{_subCommands[1]}.csv")))
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            writer.WriteLine(HeadingOfCsvFile(_subCommands[1]));
                            count++;
                        }
                        else
                        {
                            foreach (var pair in _resultsOfCommand)
                            {
                                writer.WriteLine($"{pair.Key},{pair.Value}");
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

        private string HeadingOfCsvFile(string subCommand)
        {
            switch (subCommand)
            {
                case "items":
                    return "City,Num_Items_Sold";

                case "money":
                    return "City,Money_Made";

                default:
                    return null;
            }
        } 

        public override void ExecuteCommand(TransactionDataParser transactionData)
        {
            List<Transaction> transactions = transactionData.Transactions;

            foreach (Transaction transaction in transactions)
            {
                UpdatingDictionary(transaction);
            }

            ComputeStats();
            GenerateCsv(_outputPath);
        }

        // Potentially can make this more 'DRY', seeming too much code which might be able to be simplified
        public override void ComputeStats()
        {
            if (_subCommands[1] == "items")
            {
                foreach (var pair in _tempDictionary)
                {
                    _statisticsDictionary.Add(pair.Key, pair.Value.Count);
                }

                var tempOrderedDict = _subCommands[0] == "max" ? _statisticsDictionary.OrderByDescending(x => x.Value) : _statisticsDictionary.OrderBy(x => x.Value);

                _resultsOfCommand =
                    tempOrderedDict.ToDictionary(pair => pair.Key, pair => pair.Value);
            }
            else
            {
                foreach (var pair in _tempDictionary)
                {
                    _statisticsDictionary.Add(pair.Key, pair.Value.Sum());
                }

                var tempOrderedDict = _subCommands[0] == "min" ? _statisticsDictionary.OrderBy(x => x.Value) : _statisticsDictionary.OrderByDescending(x => x.Value);
                _resultsOfCommand =
                    tempOrderedDict.ToDictionary(pair => pair.Key, pair => pair.Value);
            }
        }

        private void UpdatingDictionary(Transaction transaction)
        {
            string city = transaction.Location;
            if (!_tempDictionary.ContainsKey(city))
            {
                _tempDictionary.Add(city, new List<decimal>() { transaction.Price });
            }
            else
            {
                _tempDictionary[city].Add(transaction.Price);
            }
        }

        public override void VerifyCommand(string inputCommand)
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
