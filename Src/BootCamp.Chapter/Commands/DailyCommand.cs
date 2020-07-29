using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter.Commands
{
    class DailyCommand : Command
    {
        private readonly string _inputCommand;
        private readonly string _outputPath;
        private string _shopName;
        private bool _displayAscending;
        private readonly TransactionDataParser _transactionData;
        private Dictionary<int, List<Decimal>> _resultsOfCommand;
        private Dictionary<int, List<decimal>> _tempDictionary = new Dictionary<int, List<decimal>>();

        public DailyCommand(string inputCommand, string outputPath, TransactionDataParser transactionData)
        {
            _inputCommand = inputCommand;
            _outputPath = outputPath;
            _transactionData = transactionData;

            VerifyCommand(_inputCommand);
        }

        public override void VerifyCommand(string inputCommand)
        {
            string[] splitCommand = inputCommand.Split(' ');
            StringBuilder sb = new StringBuilder();

            foreach (string word in splitCommand)
            {
                if (word != "daily" && word[0] != '-')
                {
                    sb.Append(sb.Length == 0 ? word : $" {word}");
                }
                else if (word[0] == '-')
                {
                    if (word == "-asc")
                    {
                        _displayAscending = true;
                    }
                    else
                    {
                        throw new ArgumentException($"Additional command should be \"-asc\" not {word}");
                    }
                }
            }

            _shopName = _transactionData.Transactions.Any(x => x.ShopName == sb.ToString())
                ? sb.ToString()
                : throw new ArgumentException($"Shop Name [{sb}] is not valid");
        }

        public override void ExecuteCommand(TransactionDataParser transactionData)
        {
            _ = transactionData;

            ComputeStats();

            GenerateCsv(_outputPath);
        }

        public override void ComputeStats()
        {
            var newData = _transactionData.Transactions.Where(x => x.ShopName == _shopName);

            foreach (var trans in newData)
            {
                if (!_tempDictionary.ContainsKey(trans.TimePurchased.Hour))
                {
                    _tempDictionary.Add(trans.TimePurchased.Hour, new List<decimal>() { trans.Price });
                }
                else
                {
                    _tempDictionary[trans.TimePurchased.Hour].Add(trans.Price);
                }
            }
            
            var tempOrderedDict = _displayAscending
                ? _tempDictionary.OrderBy(x => x.Value.Sum())
                : _tempDictionary.OrderByDescending(x => x.Value.Sum());

            _resultsOfCommand =
                tempOrderedDict.ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        public void GenerateCsv(string outputPath)
        {
            try
            {
                Console.WriteLine($"Generating .csv file: [{_inputCommand}]");
                
                int count = 0;
                var newData = _transactionData.Transactions.Where(x => x.ShopName == _shopName);
                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputPath}//daily_{_shopName.Replace(' ', '_')}.csv")))
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            writer.WriteLine($"Total:,{_resultsOfCommand.Sum(x => x.Value.Sum())}");
                            writer.WriteLine($"Hour,Money Made");
                            count++;
                        }
                        else
                        {
                            
                            foreach (var keyValue in _resultsOfCommand)
                            {
                                writer.WriteLine($"{keyValue.Key},{keyValue.Value.Sum()}");
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
    }
}
