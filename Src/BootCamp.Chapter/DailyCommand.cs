using System;
using System.IO;
using System.Linq;

namespace BootCamp.Chapter
{
    internal class DailyCommand
    {
        private FileInfo _outputFile;
        private string _shopName;

        public DailyCommand(FileInfo outputFile, string shopName)
        {
            _outputFile = outputFile;
            _shopName = shopName;
        }

        internal void ExecuteCommand(Stream stream)
        {
            using var transactionStream = new TransactionStream(stream);
            var transactions = transactionStream
                .ReadTransactionUntilEnd()
                .Where(x => x.ShopName.Equals(_shopName));
            var byDayOfWeek = transactions
                .GroupBy(x => x.Time.DayOfWeek)
                .Select(x => new { Day = x.Key, Earned = x.Sum(x => x.Price) })
                .OrderBy(x => x.Day)
                .ToArray();

            using var outputText = _outputFile.CreateText();
            outputText.WriteLine("Day, Earned");
            foreach (var line in byDayOfWeek)
            {
                outputText.Write(line.Day);
                outputText.Write(", ");
                outputText.WriteLine($"\"{line.Earned:c}\"");
            }
        }
    }
}
