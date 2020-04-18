using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class TimeCommand
    {
        private FileInfo _outputFile;

        public TimeCommand(FileInfo outputFile)
        {
            _outputFile = outputFile ?? throw new ArgumentNullException(nameof(outputFile));
        }

        internal void ExecuteCommand(Stream stream)
        {
            var transactionStream = new TransactionStream(stream);
            var transactions = transactionStream.ReadTransactionUntilEnd().ToArray();

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

            outputText.Write($"Rush hour: {rushHour:00}");
        }

        private static IDictionary<int, IList<decimal>> GetEarningsByHour(IEnumerable<Transaction> transactions)
        {
            var earningsByHour = new Dictionary<int, IList<decimal>>(
                Enumerable.Range(0, 24).Select(x => new KeyValuePair<int, IList<decimal>>(x, new List<decimal>()))
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
