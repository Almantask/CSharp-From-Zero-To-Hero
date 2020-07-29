using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter.Commands
{
    class FullCommand : Command
    {
        private readonly string _inputCommand;
        private readonly string _outputPath;
        private bool _displayAscending;
        private Dictionary<string, List<Transaction>> _shopNameDictionary = new Dictionary<string, List<Transaction>>();
        private readonly TransactionDataParser _transactionData;
        private IOrderedEnumerable<Transaction> _resultsOfCommand;
        private string _currentShopName;

        public FullCommand(string inputCommand, string outputPath, TransactionDataParser transactionData)
        {
            _inputCommand = inputCommand;
            _outputPath = outputPath;
            _transactionData = transactionData;

            VerifyCommand(_inputCommand);
        }
        public override void VerifyCommand(string inputCommand)
        {
            _displayAscending = inputCommand.Split(' ')[1] == "-asc";
        }

        public override void ExecuteCommand(TransactionDataParser transactionData)
        {
            ComputeStats();

            foreach (var pair in _shopNameDictionary)
            {
                _resultsOfCommand = _displayAscending
                    ? pair.Value.OrderBy(x => x.Location)
                    : pair.Value.OrderByDescending(x => x.Location);

                _currentShopName = pair.Key;
                GenerateCsv(_outputPath);
            }
        }

        public override void ComputeStats()
        {
            List<Transaction> transactions = _transactionData.Transactions;

            foreach (Transaction transaction in transactions)
            {
                if (!_shopNameDictionary.ContainsKey(transaction.ShopName))
                {
                    _shopNameDictionary.Add(transaction.ShopName, new List<Transaction>() {transaction});
                }
                else
                {
                    _shopNameDictionary[transaction.ShopName].Add(transaction);
                }
            }
        }

        public void GenerateCsv(string outputPath)
        {
            try
            {
                Console.WriteLine($"Generating .csv file: [{_inputCommand}]");

                int count = 0;
                
                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputPath}//{_currentShopName}.csv")))
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            writer.WriteLine("City, Street, Item, DateTime, Price");
                            count++;
                        }
                        else
                        {

                            foreach (var transaction in _resultsOfCommand)
                            {
                                writer.WriteLine($"{transaction.Location}, {transaction.StreetName}, {transaction.ItemName}, {transaction.TimePurchased}, {transaction.Price.ToString().Replace('.', ',')} €");
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
