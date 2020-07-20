using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace BootCamp.Chapter
{
    public class TimeCommand : ICommand, ICsvGenerator
    {
        private TimeSpan[] _timeSpans;
        private Dictionary<int, List<decimal>> _resultsOfCommand = new Dictionary<int, List<decimal>>();
        private Dictionary<int, string[]> _computedStats = new Dictionary<int, string[]>();
        private readonly string _outputPath;
        private int highestHour = 0;
        private decimal highestEarnedHour = 0;
        private readonly string _inputCommand;

        public TimeCommand(string inputCommand, string outputPath)
        {
            _inputCommand = inputCommand;
            _outputPath = outputPath;
            _timeSpans = default;
            VerifyCommand(inputCommand);
        }

        public void ExecuteCommand(TransactionDataParser transactionData)
        {
            List<Transaction> transactions = transactionData.Transactions;
            if (_timeSpans == default)
            {
                foreach (Transaction transaction in transactions)
                {
                    int hour = transaction.TimePurchased.Hour;

                    UpdatingDictionary(transaction, hour);
                }
            }
            else
            {
                foreach (Transaction transaction in transactions)
                {
                    int hour = transaction.TimePurchased.Hour;

                    if (hour >= _timeSpans[0].Hours && hour <= _timeSpans[1].Hours)
                    {
                        UpdatingDictionary(transaction, hour);
                    }
                }
            }

            ComputeStats();
            Console.WriteLine($"Generating .csv file: [{_inputCommand}]");
            GenerateCsv(_outputPath);
        }

        private void UpdatingDictionary(Transaction transaction, int hour)
        {
            if (!_resultsOfCommand.ContainsKey(hour))
            {
                _resultsOfCommand.Add(hour, new List<decimal>() { transaction.Price });
            }
            else
            {
                _resultsOfCommand[hour].Add(transaction.Price);
            }
        }
        public void VerifyCommand(string inputCommand)
        {
            string[] splitCommand = inputCommand.Split(' ');

            if (splitCommand.Length != 1)
            {
                string[] splitTimeFilter = splitCommand[1].Split('-');

                bool time1Check = TimeSpan.TryParse(splitTimeFilter[0], out TimeSpan time1)
                    ? true
                    : throw new ArgumentException(
                        $"Time Frame given is not legitimate {splitTimeFilter[0]}. It should be [HH:mm-HH:mm]");
                bool time2Check = TimeSpan.TryParse(splitTimeFilter[1], out TimeSpan time2)
                    ? true
                    : throw new ArgumentException(
                        $"Time Frame given is not legitimate {splitTimeFilter[1]}. It should be [HH:mm-HH:mm]");

                _timeSpans = new TimeSpan[2]{time1, time2};
            }
        }

        // ToDo: Make this generic such that all the commands can implement it
        public void GenerateCsv(string outputPath)
        {
            try
            {
                int count = 0;
                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputPath}//time_command.csv")))
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
                            foreach (var hour in _computedStats)
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

        public void ComputeStats()
        {
            foreach (var hourEarnings in _resultsOfCommand)
            {
                string[] newValues = { hourEarnings.Value.Count().ToString(), hourEarnings.Value.Average().ToString() };
                _computedStats.Add(hourEarnings.Key, newValues);

                if (hourEarnings.Value.Average() > highestEarnedHour)
                {
                    highestEarnedHour = Math.Max(hourEarnings.Value.Average(), highestEarnedHour);
                    highestHour = hourEarnings.Key;
                }
            }
        }
    }
}