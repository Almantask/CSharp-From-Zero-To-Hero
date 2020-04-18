using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    internal class TimeCommand
    {
        private static readonly TimeSpan OneDay = new TimeSpan(24, 0, 0);

        private FileInfo _outputFile;
        private readonly TimeSpan _beginning;
        private readonly TimeSpan _end;

        public TimeCommand(FileInfo outputFile, CommandArgument argument)
        {
            _outputFile = outputFile ?? throw new ArgumentNullException(nameof(outputFile));

            if (argument != null)
            {
                var matches = Regex.Matches(argument.Argument, @"(\d{2}:\d{2})-(\d{2}:\d{2})");
                _beginning = TimeSpan.Parse(matches[0].Groups[1].Value);
                _end = TimeSpan.Parse(matches[0].Groups[2].Value);
            }

            if (_end == default)
            {
                _end = _end.Add(OneDay);
            }

            if (_beginning > _end)
            {
                throw new InvalidCommandException();
            }

            if (_beginning > OneDay)
            {
                throw new InvalidCommandException();
            }

            if (_end > OneDay)
            {
                throw new InvalidCommandException();
            }
        }

        internal IEnumerable<Transaction> FilterTimeOfDay(IEnumerable<Transaction> transactions)
        {
            if (_beginning == default && _end == default)
            {
                return transactions;
            }

            return transactions.Where(x => _beginning <= x.Time.TimeOfDay && x.Time.TimeOfDay <= _end);
        }

        internal void ExecuteCommand(Stream stream)
        {
            var transactionStream = new TransactionStream(stream);
            var transactions = FilterTimeOfDay(transactionStream.ReadTransactionUntilEnd()).ToArray();

            var transactionsByHours = transactions.ToLookup(x => x.Time.Hour);
            var earningsByHour = GetEarningsByHour(transactions);

            var reportLines = earningsByHour
                .Select(x => new
                {
                    Hour = x.Key,
                    Count = transactionsByHours[x.Key].Count(),
                    Earned = earningsByHour[x.Key].AverageOrZero()
                }
            ).ToArray();

            using var outputText = _outputFile.CreateText();
            outputText.WriteLine("Hour, Count, Earned");
            foreach (var line in reportLines)
            {
                var moneyString = $"\"{line.Earned:c}\"";

                outputText.Write(line.Hour.ToString("00"));
                outputText.Write(", ");
                outputText.Write(line.Count);
                outputText.Write(", ");
                outputText.WriteLine(moneyString.ToString(CultureInfo.CurrentCulture));
            }

            var rushHour = reportLines.OrderByDescending(x => x.Earned).First().Hour;

            outputText.WriteLine($"Rush hour: {rushHour:00}");
        }

        private IDictionary<int, IList<decimal>> GetEarningsByHour(IEnumerable<Transaction> transactions)
        {
            var beginningHour = (int)_beginning.TotalHours;
            var endHour = (int)_end.TotalHours;

            var earningsByHour = new Dictionary<int, IList<decimal>>(
                Enumerable.Range(beginningHour, endHour - beginningHour)
                    .Select(x => new KeyValuePair<int, IList<decimal>>(x, new List<decimal>())
                )
            );

           var transactionsByDay = transactions.GroupBy(x => x.Time.Date);

            foreach (var daysTransactions in transactionsByDay)
            {
                var byHour = daysTransactions.GroupBy(x => x.Time.Hour);
                foreach (var hour in byHour)
                {
                    earningsByHour[hour.Key].Add(hour.Sum(x => x.Price));
                }
            }

            return earningsByHour;
        }
    }
}
